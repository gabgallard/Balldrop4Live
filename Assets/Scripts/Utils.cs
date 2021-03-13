using UnityEngine;

public static class Utils
{
    public static GameObject Raycast (Camera mainCamera, Vector2 screenPosition, int layermask)
    {
        Ray ray = mainCamera.ScreenPointToRay(screenPosition);
        RaycastHit2D hit2D = Physics2D.GetRayIntersection(ray, Mathf.Infinity, layermask);
        if (hit2D.collider != null) return hit2D.collider.gameObject;
        return null;
    }
}