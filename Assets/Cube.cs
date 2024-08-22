using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    PlayerControls controls;
    public float scaleFactor = 1.1f; // The factor by which to scale the cube
    private Vector3 originalScale;
    public AudioSource sound_E;
    public AudioSource sound_A;
    public AudioSource sound_D;
    public AudioSource sound_G;
    public AudioSource sound_B;


    public GameObject BoardE;
    public GameObject BoardA;
    public GameObject BoardD;
    public GameObject BoardG;
    public GameObject BoardB;
   

    void Start()
    {
        originalScale = BoardE.transform.localScale; // Store the original scale
    }

    void Awake()
    {
        controls = new PlayerControls();

        controls.GamePlay.Green.performed += ctx => GreenPressed();
        controls.GamePlay.Green.canceled += ctx => GreenReleased(); 

        controls.GamePlay.Red.performed += ctx => RedPressed();
        controls.GamePlay.Red.canceled += ctx => RedReleased();

        controls.GamePlay.Yellow.performed += ctx => YellowPressed();
        controls.GamePlay.Yellow.canceled += ctx => YellowReleased();

        controls.GamePlay.Blue.performed += ctx => BluePressed();
        controls.GamePlay.Blue.canceled += ctx => BlueReleased();

        controls.GamePlay.Orange.performed += ctx => OrangePressed();
        controls.GamePlay.Orange.canceled += ctx => OrangeReleased();

        controls.GamePlay.StrumUp.performed += ctx => Strum();
        controls.GamePlay.StrumDown.performed += ctx => Strum();
    }
    //green buttons E
    void GreenPressed()
    {
        Debug.Log("green pressed");
        BoardE.transform.localScale = originalScale * scaleFactor; // Increase the size
        sound_E.Play();
    }
       
    void GreenReleased()
    {
        Debug.Log("green released");
        BoardE.transform.localScale = originalScale; // Revert to the original size
    }
    //red buttons A
    void RedPressed()
    {
        Debug.Log("red pressed");
        BoardA.transform.localScale = originalScale * scaleFactor;
        sound_A.Play();
    }
    void RedReleased()
    {
        Debug.Log("blue released");
        BoardA.transform.localScale = originalScale;
    }
    //yellow buttons D
    void YellowPressed()
    {
        Debug.Log("yellow pressed");
        BoardD.transform.localScale = originalScale * scaleFactor;
        sound_D.Play();
    }
    void YellowReleased()
    {
        Debug.Log("yellow released");
        BoardD.transform.localScale = originalScale;
    }
    //blue buttons G

    void BluePressed()
    {
        Debug.Log("blue pressed");
        BoardG.transform.localScale = originalScale * scaleFactor;
        sound_G.Play();
    }

    void BlueReleased()
    {
        Debug.Log("blue released");
        BoardG.transform.localScale = originalScale;
    }
    //Orange buttons b
    void OrangePressed()
    {
        Debug.Log("orange pressed");
        BoardB.transform.localScale = originalScale * scaleFactor;
        sound_B.Play();
    }
    void OrangeReleased()
    {
        Debug.Log("blue released");
        BoardB.transform.localScale = originalScale;
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
