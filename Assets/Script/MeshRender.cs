using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshRender : MonoBehaviour
{
        public MeshRenderer meshRenderer;

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

        void Update()
        {
            CheckMeshRenderer();
        }
}
