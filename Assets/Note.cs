using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public GameControl _manager;
    public NoteHolder _bpm;
    public bool canBePressed;
    public Cube guitarControl;  // Handles button press states
    public PlayerControls controls;

    // This will store the color of the note (e.g., "Green", "Red", etc.)
    public string noteColor;

    void Start()
    {
        //_manager = GameObject.Find("GameManager").GetComponent<GameControl>();
    }
    void Awake()
    {
        controls = new PlayerControls();
      //  _manager = GameObject.Find("GameManager").GetComponent<GameManager>();
        // Set up input listeners for button presses and releases
        controls.GamePlay.Green.performed += ctx => guitarControl.GreenPressed();
        controls.GamePlay.Green.canceled += ctx => guitarControl.GreenReleased();

        // Repeat for other colors
        // ...
    }

    void Update()
    {
        // Check if any button is pressed AND strum is pressed
        if ((guitarControl.gPress || guitarControl.rPress || guitarControl.yPress ||
             guitarControl.bPress || guitarControl.oPress) && guitarControl.strum)
        {
            if (canBePressed)
            {
                Debug.Log("checking match!");
                CheckMatch();
            }
        }
    }

    void CheckMatch()
    {
        // Check if the button pressed matches the note's color
        if (guitarControl.gPress && noteColor == "Green")
        {
            Debug.Log("Green note hit!");
            this.gameObject.SetActive(false);
            _manager.playerScore += 1;
            _manager.jam.value += 2;
           
        }
        else if (guitarControl.rPress && noteColor == "Red")
        {
            Debug.Log("Red note hit!");
            this.gameObject.SetActive(false);
            _manager.playerScore += 1;
            _manager.jam.value += 2;

        }
        else if (guitarControl.yPress && noteColor == "Yellow")
        {
            Debug.Log("Yellow note hit!");
            this.gameObject.SetActive(false);
            _manager.playerScore += 1;
            _manager.jam.value += 2;

        }
        else if (guitarControl.bPress && noteColor == "Blue")
        {
            Debug.Log("Blue note hit!");
            this.gameObject.SetActive(false);
            _manager.playerScore += 1;
            _manager.jam.value += 2;

        }
        else if (guitarControl.oPress && noteColor == "Orange")
        {
            Debug.Log("Orange note hit!");
            this.gameObject.SetActive(false);
            _manager.playerScore += 1;
            _manager.jam.value += 2;

        }
        else
        {
            Debug.Log("Wrong button pressed!");
            _manager.playerScore -= 1;
            _manager.jam.value += 0.2f;

        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the player can press this note
        if (other.tag == "Activator")
        {
            canBePressed = true;

            // Assign the note color based on the tag of the note (assuming the note's tag is its color)
            
        }
        if(other.tag == "BoomBar")
        {
            _manager.playerScore -= 1;
            
            this.gameObject.SetActive(false);
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = false;
        }

        if (other.tag == "BoomBar")
        {
            _manager.playerScore -= 1;

            this.gameObject.SetActive(false);
        }
    }
}
