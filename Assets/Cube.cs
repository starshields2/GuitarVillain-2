using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    PlayerControls controls;
    public float rotationIncrement = 45.0f; // The amount to rotate each time Strum is called
    private float currentRotationX = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Awake()
    {
        controls = new PlayerControls();

        controls.GamePlay.Green.performed += ctx => GreenPressed();
        controls.GamePlay.Red.performed += ctx => RedPressed();
        controls.GamePlay.StrumUp.performed += ctx => Strum();
        controls.GamePlay.StrumDown.performed += ctx => Strum();
    }

    void GreenPressed()
    {
        Debug.Log("green pressed");
        transform.localScale *= 1.1f;
    }
    void RedPressed()
    {
        Debug.Log("red pressed");
        // Get the current scale
        Vector3 currentScale = transform.localScale;

        // Decrease the scale by dividing by 1.1
        Vector3 newScale = currentScale / 1.1f;

        // Apply the new scale
        transform.localScale = newScale;
    }

    void Strum()
    {
        Debug.Log("Strum");
        transform.Rotate(45f, 10f, 4f);
    }

    void OnEnable()
    {
        controls.GamePlay.Enable();
    }

    void OnDisable()
    {
        controls.GamePlay.Disable();
    }
}
