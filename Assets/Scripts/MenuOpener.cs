using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuOpener : MonoBehaviour
{
    public GameObject menu;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(Click);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Click()
    {
        menu.SetActive(!menu.activeSelf);
    }
}
