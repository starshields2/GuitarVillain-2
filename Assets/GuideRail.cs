using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideRail : MonoBehaviour
{
    public MeshRenderer mesh;
    public Material[] material;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MeshSwap()
    {
        mesh.material = material[1];
    }

    public void MeshReverse()
    {
        mesh.material = material[0];
    }
}
