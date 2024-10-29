using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LightSwitch : MonoBehaviour
{
    GameObject[] theLights;
    bool swapped = false;
    [SerializeField]
    Color Default;

    void Start()
    {
        List<Color> colors = new List<Color>();

        theLights = GameObject.FindGameObjectsWithTag("ColoredLightsMain");

        for (int i = 0; i < theLights.Length; i++)
        {
            theLights[i].GetComponent<Light2D>().color = Default;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            colorSwap();
        }
    }

    private void colorSwap()
    {
        if (swapped == false)
        {
            for (int i = 0; i < theLights.Length; i++)
            {
                theLights[i].GetComponent<Light2D>().color = Color.white;
                theLights[i].GetComponent<Light2D>().pointLightOuterRadius += 5;
                theLights[i].GetComponent<Light2D>().falloffIntensity -= 0.25f;
                theLights[i].GetComponent<Light2D>().shadowIntensity -= 0.75f;
            }
            swapped = true;
        }
        else if (swapped == true)  
        {
            for (int i = 0; i < theLights.Length; i++)
            {
                theLights[i].GetComponent<Light2D>().color = Color.red;
                theLights[i].GetComponent<Light2D>().pointLightOuterRadius -= 5;
                theLights[i].GetComponent<Light2D>().falloffIntensity += 0.25f;
                theLights[i].GetComponent<Light2D>().shadowIntensity += 0.75f;
            }
            swapped = false;
        }
    }
}
