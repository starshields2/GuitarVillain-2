using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomBar : MonoBehaviour
{
    public GameObject overCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "BoomBar")
        {
            Debug.Log("finish");
            overCanvas.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
