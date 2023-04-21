using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider that entered is tagged as "bullet"
        if (other.CompareTag("bullet"))
        {
            // Destroy the game object this script is attached to (the enemy prefab)
            Destroy(gameObject);
        }
    }
}