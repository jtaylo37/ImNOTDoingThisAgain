using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day_Night : MonoBehaviour
{
    // Start is called before the first frame update

    private float rotationSpeed = 5f;
    public float current = 0f;

    // Update is called once per frame
    void Update()
    {
        current += rotationSpeed * Time.deltaTime;
        if (current > 360f)
        {
            current -= 360f;
        }
        transform.rotation = Quaternion.Euler(current, transform.rotation.y, transform.rotation.z); 
    }
}
