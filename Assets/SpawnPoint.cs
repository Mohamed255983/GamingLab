using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform enemy;

    // Assign the spawn location in the Inspector.
    public Transform spawnPoint;

    void RespawnEnemy()
    {
        // Create an instance of the enemy at the spawn point's position and rotation.
        Instantiate(
            enemy,
            spawnPoint.transform.position,
            spawnPoint.transform.rotation
        );
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            RespawnEnemy();
        }
    }
}

