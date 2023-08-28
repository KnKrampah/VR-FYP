using UnityEngine;

public class RotatingObject : MonoBehaviour
{
    public float rotationSpeed = 50f;
    public GameObject infoCanvas;
    private bool isRotating = false;

    private void Start()
    {
        // Hide the canvas panel initially
        infoCanvas.SetActive(false);
    }

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
        // Toggle the rotation on click
        ToggleRotation();

        // Toggle the canvas
        infoCanvas.SetActive(isRotating);
    }

    private void ToggleRotation()
    {
        isRotating = !isRotating;
    }
}
