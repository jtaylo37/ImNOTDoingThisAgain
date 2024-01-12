using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleMove : MonoBehaviour
{
    private float speed = 2f;
    private Vector3 direction;

    private Day_Night dayNightScript; // reference to the Day_Night script

    void Start()
    {
        // find the Directional Light object and get the Day_Night script attached to it
        GameObject directionalLightObj = GameObject.Find("Directional Light");
        dayNightScript = directionalLightObj.GetComponent<Day_Night>();
    }

    void Update()
    {
        float current = dayNightScript.current; // get the current value from the Day_Night script

        if (current >= 0 && current < 180)
        {
            direction = Vector3.right;
        }
        else if (current >= 180 && current <= 360)
        {
            direction = Vector3.left;
        }
        else if (current > 360)
        {
            current = 0;
        }

        transform.position += direction * speed * Time.deltaTime;

        Object.Destroy(this.gameObject, 25);
    }

}
