using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleporterV2 : MonoBehaviour
{
    private GameObject currentTeleporter;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) // E is used to teleport
        {
            if (currentTeleporter != null && ScoreManager.score >= 1)
            {
                ScoreManager.instance.ChangeScore(-1);
                transform.position = currentTeleporter.GetComponent<Teleporter>().GetDestination().position;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) // Assigns current teleporter we are standing on to currentTeleporter
    {
        if (collision.CompareTag("Teleporter"))
        {
            currentTeleporter = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision) // Assigns null to currentTeleporter when we leave it 
    {
        if (collision.CompareTag("Teleporter"))
        {
            if (collision.gameObject == currentTeleporter)
            {
                currentTeleporter = null;
            }
        }
    }
}
