using UnityEngine;

public class RotatingObject : MonoBehaviour
{
    public float rotationSpeed = 50f;
    public GameObject infoCanvas;
    private bool isCanvasActive = false;
    private bool isRotating = false;

    private void Update()
    {
        if (isRotating)
        {
            // Rotate the object while isRotating is true
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }

    private void OnMouseDown()
    {
        // Toggle the canvas and rotation on click
        ToggleCanvas();
        ToggleRotation();
    }

    private void ToggleCanvas()
    {
        isCanvasActive = !isCanvasActive;
        infoCanvas.SetActive(isCanvasActive);
    }

    private void ToggleRotation()
    {
        isRotating = !isRotating;
    }
}
