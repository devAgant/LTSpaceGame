using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class KeybindManagerV2 : MonoBehaviour
{
    private static KeybindManagerV2 instance;
    private string bindName = null;
    private bool changingKey = false;

    public static KeybindManagerV2 Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<KeybindManagerV2>();
            }
            return instance;
        }
    }

    public void KeyBindOnClick(string bindName)
    {
        this.bindName = bindName;
        changingKey = true;
        while(changingKey)
        {
            if ((bindName != string.Empty) && (bindName != null))
            {
                Event e = Event.current;
                if (e.isKey) 
                {
                    Debug.Log("Name: " + bindName + "          Code: " + e.keyCode);
                    GameInputManager.SetKeyMap(bindName, e.keyCode);
                    bindName = null;
                    changingKey = false;
                }
            }
        }
    }
    
    /*
    private void OnGUI()
    {
        if ((bindName != string.Empty) && (bindName != null))
        {
            Event e = Event.current;
            if (e.isKey) {
                Debug.Log("Name: " + bindName + "          Code: " + e.keyCode);
                GameInputManager.SetKeyMap(bindName, e.keyCode);
                bindName = null;
            }
        }
    }
    */
}
