using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public GameObject inventoryMenu;
    public KeyCode keyCode;
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyCode)) {
            inventoryMenu.gameObject.SetActive(!inventoryMenu.gameObject.activeSelf);
        }
        
    }
}
