using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float variable;
    public GameObject prefabToMove;

    private float direction = 1f;

    private void Start()
    {
        InvokeRepeating("IncrementVariable", 1f, 1f);
    }

    private void Update()
    {
        if (variable >= 0f && variable < 180f)
        {
            direction = 1f;
        }
        else if (variable >= 180f && variable < 360f)
        {
            direction = -1f;
        }

        prefabToMove.transform.position += new Vector3(direction * Time.deltaTime, 0f, 0f);

        if (variable >= 360f)
        {
            variable = 0f;
        }
    }

    private void IncrementVariable()
    {
        variable += 5f;
    }
}
