using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turtleMaker : MonoBehaviour
{
    public GameObject prefab; // The prefab to instantiate
    public float spawnInterval = 1f; // The time interval between each prefab instantiation
    public float spawnDuration = 10f; // The total duration of the spawning process
    public float spawnRadius = 15f; // The radius of the area within which to spawn prefabs
    private float spawnTimer = 0f;

    // Update is called once per frame
    void Update()
    {

        if (spawnTimer < spawnDuration)
        {
            // If not, update the spawn timer
            spawnTimer += Time.deltaTime;
            // Check if the time interval between prefab instantiations has elapsed
            if (spawnTimer >= spawnInterval)
            {
                // If so, reset the spawn timer and instantiate a new prefab
                spawnTimer = 0f;
                Vector3 spawnPosition = transform.position + Random.insideUnitSphere * spawnRadius; // Randomly generate a position within the spawn area
                spawnPosition.y = -.16f; // Ensure that the prefab is spawned at ground level
                Quaternion spawnRotation = Quaternion.Euler(0f, 85.305f, 0f); // Create the desired rotation Quaternion
                Instantiate(prefab, spawnPosition, spawnRotation); // Instantiate the prefab at the generated position
            }

        }
    }
}
