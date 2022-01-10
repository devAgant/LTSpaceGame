using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class OptionsManager : MonoBehaviour
{
    private GameObject[] keybindButtons;

    // Update is called once per frame
    private static OptionsManager instance;
    public static OptionsManager MyInstance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<OptionsManager>();
            }

            return instance;
        }
    }
    void Awake()
    {
        keybindButtons = GameObject.FindGameObjectsWithTag("Keybind");
        Debug.Log(keybindButtons);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateKeyText(string key, KeyCode code) // TODO fix
    {
        Text tmp = Array.Find(keybindButtons, x => x.name == key).GetComponentInChildren<Text>();
        tmp.text = code.ToString();
    }
}
