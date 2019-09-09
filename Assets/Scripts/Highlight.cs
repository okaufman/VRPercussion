using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlight : MonoBehaviour
{
    public Light spotLight;
    public Light[] noSpotLight;
    public KeyCode keyCode;

    private void Start()
    {
        spotLight.intensity = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyCode))
        {
            spotLight.intensity = 1;
            foreach(Light lights in noSpotLight)
            {
                lights.intensity = 0;
            }
        }
    }
}
