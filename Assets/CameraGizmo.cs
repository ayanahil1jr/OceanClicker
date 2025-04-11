using UnityEngine;

[ExecuteInEditMode] // Ensure the gizmo is drawn in the scene view while editing
public class CameraGizmo : MonoBehaviour
{
    public Camera targetCamera; // Drag the camera here in the Inspector
    public float aspectWidth = 9f; // Aspect ratio width (9)
    public float aspectHeight = 16f; // Aspect ratio height (16)

    void OnDrawGizmos()
    {
        if (targetCamera == null) return;

        // Calculate the aspect ratio scale
        float cameraHeight = targetCamera.orthographicSize * 2f;
        float cameraWidth = cameraHeight * aspectWidth / aspectHeight;

        // Draw a rectangle to represent the camera's border
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(targetCamera.transform.position, new Vector3(cameraWidth, cameraHeight, 0));
    }
}
