using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshRender : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
          meshRenderer = GetComponent<MeshRenderer>();
    }

  

     void CheckMeshRenderer()
     {
  
    if (meshRenderer.enabled == true)
    {
        Debug.Log("MeshRender true");
    }
}



    // Update is called once per frame
    void Update()
    {
         CheckMeshRenderer();
    }
}
