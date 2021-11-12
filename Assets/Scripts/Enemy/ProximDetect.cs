using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximDetect : MonoBehaviour
{
    //Initializes the different variables

    public SpriteRenderer SpriteRenderer = new SpriteRenderer();
   public Collider m_ObjectCollider;
   //Determines whether the player is in the enemy's FOV
    public static bool isTriggered;
    public SpriteRenderer sprite;
    //Every frame, the current object's collider (or the enemy's in this case) is called as well as the sprite's
   void Start()
   {
       m_ObjectCollider = GetComponent<Collider>();
       sprite = GetComponent<SpriteRenderer>();
       
   }

   //OnTriggerExit2D checks if the player has left the enemy's FOV
    void OnTriggerExit2D(Collider2D other)
    {
        isTriggered = false;
    }
    //OnTriggerEnter2D checks if the player is in the enemy's FOV
    void OnTriggerEnter2D(Collider2D other)
    {
        isTriggered = true;
    }
    //Updates the Color
   void Update()
   {
       
        if(isTriggered == true)
        {
            sprite.color = Color.green;
        }
        else 
        {
            sprite.color = Color.red;
        }
   }
}
