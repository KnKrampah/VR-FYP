using UnityEngine;

public class TestTubeRotation : MonoBehaviour
{
    public float verticalSpeed = 2f;
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
        // Move the object vertically
        transform.Translate(Vector3.up * verticalSpeed * Time.deltaTime);

        // Rotate the object around its own axis if clicked
        if (isRotating)
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }

    private void OnMouseDown()
    {
        // Toggle rotation and canvas display on click
        ToggleRotation();
        ToggleCanvas();
    }

    private void ToggleRotation()
    {
        isRotating = !isRotating;
    }

    private void ToggleCanvas()
    {
        infoCanvas.SetActive(isRotating);
    }
}
