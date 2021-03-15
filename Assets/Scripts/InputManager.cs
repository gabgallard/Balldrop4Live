
using UnityEngine;

public class InputManager : MonoBehaviour
{
    #region Events
    public delegate void StartDraw();
    public event StartDraw OnStartDraw;
    public delegate void EndDraw();
    public event StartDraw OnEndDraw;
    public delegate void StartErase();
    public event StartDraw OnStartErase;
    public delegate void EndErase();
    public event StartDraw OnEndErase;
    #endregion

    private GeneralControls mouseControls;

    private void Awake()
    {
        mouseControls = new GeneralControls();
    }

    public void OnEnable()
    {
        mouseControls.Enable();
    }

    public void OnDisable()
    {
        mouseControls.Disable();
    }
    void Start()
    {
        mouseControls.Mouse.Click.started += _ => { if (OnStartDraw != null) OnStartDraw(); };
        mouseControls.Mouse.Click.canceled += _ => { if (OnEndDraw != null) OnEndDraw(); };
        mouseControls.Mouse.Erase.started += _ => { if (OnStartErase != null) OnStartErase(); };
        mouseControls.Mouse.Erase.canceled += _ => { if (OnEndErase != null) OnEndErase(); };

        //Cursor.lockState = CursorLockMode.Confined;
    }

    public Vector2 GetMousePosition()
    {
        return mouseControls.Mouse.Position.ReadValue<Vector2>();
    }
}
