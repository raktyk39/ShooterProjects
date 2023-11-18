using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshRender : MonoBehaviour
{
    public MeshRenderer meshRenderer;

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void CheckMeshRenderer()
    {
        if (meshRenderer.enabled == true)
        {
            Debug.Log("MeshRender true");
        }
    }

    private void Update()
    {
        CheckMeshRenderer();
    }
}
