using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LightSwitch : MonoBehaviour
{

    void Start()
    {
        Component[] Lights = GetComponentsInChildren<Light2D>();
    }

    void Update()
    {
        
    }
}
