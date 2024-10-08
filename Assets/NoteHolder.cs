using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteHolder : MonoBehaviour
{
    public GameObject E;
    public GameObject A;
    public GameObject D;
    public GameObject G;
    public GameObject B;

    public float bpm = 60f;
    public bool hasStarted;
    // Start is called before the first frame update
    void Start()
    {
        bpm = bpm / 60f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            if (Input.anyKeyDown)
            {
                hasStarted = true;
            }

        }
        else
        {
            transform.position -= new Vector3(0f, 0f, bpm * Time.deltaTime);
        }

        if(bpm <= 0f)
        {
            bpm = 1f;
        }
    }
}
