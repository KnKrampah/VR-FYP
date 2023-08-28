using UnityEngine;
using TMPro;

public class SpinAndPopup : MonoBehaviour
{
    public float rotationSpeed = 30.0f;
    public string popupText = "This is the object's information.";

    private bool isMouseOver = false;
    private bool shouldRotate = false;
    private Canvas popupCanvas;
    private TextMeshProUGUI popupTextUI;

    private void Start()
    {
        // Create the popup Canvas dynamically
        popupCanvas = Instantiate(Resources.Load<Canvas>("PopupCanvasPrefab"));
        popupCanvas.enabled = false; // Hide initially

        // Get the TextMeshPro component from the popup Canvas
        popupTextUI = popupCanvas.GetComponentInChildren<TextMeshProUGUI>();
        popupTextUI.text = popupText; // Set initial text
    }

    private void Update()
    {
        // Rotate the object
        if (shouldRotate)
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }

    private void OnMouseEnter()
    {
        // Display information and start rotation when the mouse enters the object's collider
        isMouseOver = true;
        shouldRotate = true;
        ShowPopup();
    }

    private void OnMouseExit()
    {
        // Hide the information popup and stop rotation when the mouse exits the object's collider
        isMouseOver = false;
        shouldRotate = false;
        HidePopup();
    }

    private void ShowPopup()
    {
        // Show the information popup by enabling the Canvas
        popupCanvas.enabled = true;
    }

    private void HidePopup()
    {
        // Hide the information popup by disabling the Canvas
        popupCanvas.enabled = false;
    }
}
