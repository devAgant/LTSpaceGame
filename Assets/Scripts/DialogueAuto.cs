using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueAuto : MonoBehaviour
{
    //Initializes the different variables
    public GameObject inventoryMenu;
    public KeyCode keyCode;
    public SpriteRenderer SpriteRenderer = new SpriteRenderer();
    public Collider m_ObjectCollider;
    //Determines whether the player is in the enemy's FOV
    public static bool isTriggered;
    public SpriteRenderer sprite;
    bool isVis;
    //Every frame, the current object's collider (or the enemy's in this case) is called as well as the sprite's
    void Start()
    {
        m_ObjectCollider = GetComponent<Collider>();
        sprite = GetComponent<SpriteRenderer>();
        isVis = false;
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

        if (isTriggered == true)
        {
            if (Input.GetKeyDown(keyCode))
            {
                isVis = !isVis;
                transform.root.Find("PopUp").gameObject.SetActive(isVis);
            }

        }
        else
        {
            transform.root.Find("PopUp").gameObject.SetActive(false);
            isVis = false;
        }
    }
}
