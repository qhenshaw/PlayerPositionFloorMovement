using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalShaderPositionReference : MonoBehaviour
{
    [SerializeField] private string _shaderReferenceName = "_PlayerPosition";

    private void Update()
    {
        Shader.SetGlobalVector(_shaderReferenceName, transform.position);
    }
}
