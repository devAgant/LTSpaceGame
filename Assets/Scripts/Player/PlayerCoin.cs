using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCoin : MonoBehaviour
{   
    private void OnTriggerEnter2D (Collider2D other) // you can use this script, but it's already inmplemented in Coin Script
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
        }
    }
}
