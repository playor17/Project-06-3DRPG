using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBallDestroyer : MonoBehaviour
{
    // Static variable for DragonBall Score
    public static int DBallScore = 0;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collided object has the "Player" tag
        if (other.CompareTag("Player"))
        {
            // Increase the score
            DBallScore += 1;

            // Debug log for tracking score
            Debug.Log("DBall destroyed! Current score: " + DBallScore);

            // Destroy this object
            Destroy(gameObject);

            // Check if the score reaches 7
            if (DBallScore == 7)
            {
                // Deactivate all objects with the "npc" tag
                DeactivateAllNPCs();
            }
        }
    }

    // Method to deactivate all GameObjects with the "npc" tag
    private void DeactivateAllNPCs()
    {
        // Find all GameObjects with the "npc" tag
        GameObject[] npcs = GameObject.FindGameObjectsWithTag("npc");

        // Loop through and deactivate each NPC
        foreach (GameObject npc in npcs)
        {
            npc.SetActive(false);
            Debug.Log("NPC deactivated: " + npc.name);
        }

        // If no NPCs are found, log it
        if (npcs.Length == 0)
        {
            Debug.Log("No NPCs found with the 'npc' tag!");
        }
    }
}
