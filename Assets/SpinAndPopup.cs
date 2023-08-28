using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpinAndPopup : MonoBehaviour
{
    public float rotationSpeed = 30.0f;
    public string popupText = "This is a box.";

    private bool isMouseOver = false;
    private Canvas canvas;
    private TextMeshProUGUI popupTextUI;

    private void Start()
    {
        // Get the Canvas and TextMeshPro component
        canvas = FindObjectOfType<Canvas>();
        popupTextUI = canvas.GetComponentInChildren<TextMeshProUGUI>();
    }

    private void Update()
    {
        // Rotate the object
        if (!isMouseOver)
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }

    private void OnMouseEnter()
    {
        // Display information when the mouse enters the object's collider
        isMouseOver = true;
        ShowPopup(popupText);
    }

    private void OnMouseExit()
    {
        // Hide the information popup when the mouse exits the object's collider
        isMouseOver = false;
        HidePopup();
    }

    private void ShowPopup(string text)
    {
        // Show the information popup by enabling the Canvas and setting the text
        canvas.enabled = true;
        popupTextUI.text = text;
    }

    private void HidePopup()
    {
        // Hide the information popup by disabling the Canvas
        canvas.enabled = false;
    }
}
