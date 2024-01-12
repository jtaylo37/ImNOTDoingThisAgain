using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyChange : MonoBehaviour
{
    private Day_Night dayNightScript; // reference to the Day_Night script
    public Material dayMaterial; // The material to use when the value is over the threshold
    public Material nightMaterial; // The material to use when the value is under the threshold
    private Renderer sphereRenderer;

    void Start()
    {
        // find the Directional Light object and get the Day_Night script attached to it
        GameObject directionalLightObj = GameObject.Find("Directional Light");
        dayNightScript = directionalLightObj.GetComponent<Day_Night>();
        sphereRenderer = GetComponent<Renderer>(); // Get the renderer component of the sphere
        // Set the initial material to underMaterial
        sphereRenderer.material = dayMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        float current = dayNightScript.current;

        if (current >= 0 && current < 180)
        {
            sphereRenderer.material = dayMaterial;
        }
        else if (current >= 180 && current <= 360)
        {
            sphereRenderer.material = nightMaterial;
        }
        else if (current > 360)
        {
            current = 0;
        }
    }
}
