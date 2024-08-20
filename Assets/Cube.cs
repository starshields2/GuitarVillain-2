using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    PlayerControls controls;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Awake()
    {
        controls = new PlayerControls();

        controls.GamePlay.Green.performed += ctx => GreenPressed();
    }

    void GreenPressed()
    {
        Debug.Log("green pressed");
        transform.localScale *= 1.1f;
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
