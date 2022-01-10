using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{

    public Transform spawnPos;
    public GameObject ItemToSpawn;
    public int amount = 1;
    //public GameObject Host;

    /*    
    private int Hp = 100;

    // Update is called once per frame
    void Update()
    {
        isDead();
    }
    
    private void OnTriggerEnter2D (Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
    
    private void isDead()
    {
        if(Host == null || Hp == 0)
        {
            for(int i = 0; i < amount; i++)
            {
                Instantiate(ItemToSpawn, spawnPos.position, spawnPos.rotation);
            }
            Destroy(gameObject);
        }
    }
    */
    
    private void OnDestroy()
    {
        for(int i = 0; i < amount; i++)
        {
            Instantiate(ItemToSpawn, spawnPos.position, spawnPos.rotation);
        }
    }
}
