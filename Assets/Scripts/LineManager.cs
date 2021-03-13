using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(InputManager))]
public class LineManager : MonoBehaviour
{

    [SerializeField]
    private float lineSeparationDistance = .2f;
    [SerializeField]
    private float lineWidth = .1f;
    [SerializeField]
    private Color lineColor = Color.white;
    [SerializeField]
    private int lineCapVertices = 5;
    #region Private
    private List<GameObject> lines;
    private List<Vector2> currentLine;
    private LineRenderer currentLineRenderer;
    private EdgeCollider2D currentLineEdgeCollider;

    private bool drawing = false;
    private bool erasing = false;

    private Camera mainCamera;

    private InputManager inputManager;

    #endregion

    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
        mainCamera = Camera.main;
    }
    private void OnEnable()
    {
        inputManager.OnStartDraw += OnStartDraw;
        inputManager.OnEndDraw += OnEndDraw;
        inputManager.OnStartErase += OnStartErase;
        inputManager.OnEndErase += OnEndErase;
    }

    private void OnDisable()
    {
        inputManager.OnStartDraw -= OnStartDraw;
        inputManager.OnEndDraw -= OnEndDraw;
        inputManager.OnStartErase -= OnStartErase;
        inputManager.OnEndErase -= OnEndErase;
    }

    #region Drawing
    private void OnStartDraw()
    {
        if (!erasing) //to not draw while erasing
            StartCoroutine("Drawing");
    }
    private void OnEndDraw()
    {
        drawing = false;
    }

    IEnumerator Drawing()
    {
        drawing = true;
        StartLine();
        while (drawing)
        {
            AddPoint(GetCurrentWorldPoint());
            yield return null;
        }
        EndLine();
    }

    private void StartLine()
    {
        // Instantiating the new line
        currentLine = new List<Vector2>();
        GameObject currentLineObject = new GameObject();
        currentLineObject.name = "Line";
        currentLineObject.transform.parent = transform;
        currentLineRenderer = currentLineObject.AddComponent<LineRenderer>();
        currentLineEdgeCollider = currentLineObject.AddComponent<EdgeCollider2D>();

        // Set settings
        currentLineRenderer.positionCount = 0;
        currentLineRenderer.startWidth = lineWidth;
        currentLineRenderer.endWidth = lineWidth;
        currentLineRenderer.numCapVertices = lineCapVertices;
        currentLineRenderer.material = new Material(Shader.Find("Particles/Standard Unlit"));
        currentLineRenderer.startColor = lineColor;
        currentLineRenderer.endColor = lineColor;
        currentLineEdgeCollider.edgeRadius = .05f;
        currentLineObject.layer = 0b110; //0b110 is binary for "6", as for layer 6 
    }

    private void EndLine()
    {
        currentLineEdgeCollider.SetPoints(currentLine);
    }
    private void AddPoint(Vector2 point)
    {
        if (PlacePoint(point))
        {
            currentLine.Add(point);
            currentLineRenderer.positionCount++;
            currentLineRenderer.SetPosition(currentLineRenderer.positionCount - 1, point);
        }
    }
    private bool PlacePoint(Vector2 point)
    {
        if (currentLine.Count == 0) return true;
        if (Vector2.Distance(point, currentLine[currentLine.Count - 1]) < lineSeparationDistance)
            return false;
        return true;
    }
    #endregion
    private void OnStartErase()
    {
        if (!drawing)
            StartCoroutine("Erasing");
    }
    private void OnEndErase()
    {
        erasing = false;
    }

    IEnumerator Erasing()
    {
        erasing = true;
        while (erasing)  
        {
            Vector2 screenMousePosition = GetCurrentScreenPoint();
            GameObject g = Utils.Raycast(mainCamera, screenMousePosition, LayerMask.GetMask("Lines")); //0b110 is binary for "6", as for layer 6 
            if (g != null) DestroyLine(g);
            yield return null;
        }
    }

    private void DestroyLine(GameObject g)
    {
        Destroy(g);
    }

    private Vector2 GetCurrentScreenPoint()
    {
        return inputManager.GetMousePosition();
    }
    private Vector2 GetCurrentWorldPoint()
    {
        return mainCamera.ScreenToWorldPoint(inputManager.GetMousePosition());
    }
}
