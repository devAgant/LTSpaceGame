using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStart : MonoBehaviour
{
    public ProximDetect proximityDetectScript;
    public GameObject player;
// Start is called before the first frame update
    void Start()
    {
        
     
    
    }
    
    // Update is called once per frame
    void Update()
    {
        if(proximityDetectScript.returnTriggerValue() == true)
        {
            GameObject.Find("Player").GetComponent<PlayerMovement>().enabled = false;
        }
        
    }
}