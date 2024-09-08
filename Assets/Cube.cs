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

    public bool gPress;
    public bool rPress;
    public bool yPress;
    public bool bPress;
    public bool oPress;
    public bool strum;

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
        controls.GamePlay.StrumUp.canceled += ctx => StrumRelease();
        controls.GamePlay.StrumDown.canceled += ctx => StrumRelease();
    }
    //green buttons E
   public void GreenPressed()
    {
        gPress = true;
      //  Debug.Log("green pressed");
        BoardE.transform.localScale = originalScale * scaleFactor; // Increase the size
        sound_E.Play();
    }
       
  public  void GreenReleased()
    {
        gPress = false;
     //   Debug.Log("green released");
        BoardE.transform.localScale = originalScale; // Revert to the original size
    }
    //red buttons A
    void RedPressed()
    {
        rPress = true;
      //  Debug.Log("red pressed");
        BoardA.transform.localScale = originalScale * scaleFactor;
        sound_A.Play();
    }
    void RedReleased()
    {
        rPress = false;
      //  Debug.Log("blue released");
        BoardA.transform.localScale = originalScale;
    }
    //yellow buttons D
    void YellowPressed()
    {
        yPress = true;
       // Debug.Log("yellow pressed");
        BoardD.transform.localScale = originalScale * scaleFactor;
        sound_D.Play();
    }
    void YellowReleased()
    {
        yPress = false;
      //  Debug.Log("yellow released");
        BoardD.transform.localScale = originalScale;
    }
    //blue buttons G

    void BluePressed()
    {
        bPress = true;
     //   Debug.Log("blue pressed");
        BoardG.transform.localScale = originalScale * scaleFactor;
        sound_G.Play();
    }

    void BlueReleased()
    {
        bPress = false;
      //  Debug.Log("blue released");
        BoardG.transform.localScale = originalScale;
    }
    //Orange buttons b
    void OrangePressed()
    {
        oPress = true;
       // Debug.Log("orange pressed");
        BoardB.transform.localScale = originalScale * scaleFactor;
        sound_B.Play();
    }
    void OrangeReleased()
    {
        oPress = false; 
      //  Debug.Log("blue released");
        BoardB.transform.localScale = originalScale;
    }
    void Strum()
    {
        strum = true;
       // Debug.Log("Strum");
        transform.Rotate(45f, 10f, 4f);
    }

    void StrumRelease()
    {
        strum = false;
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
