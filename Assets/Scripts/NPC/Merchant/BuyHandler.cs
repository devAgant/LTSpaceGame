using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BuyHandler : MonoBehaviour, IPointerClickHandler
{
    Button buyButton;
    Image[] itemButtons;
    bool[] itemButtonsSelected;
    bool isTriggered;
    public GameObject merchant;
    private static bool exitHasBeenCalled;

    public void OnPointerClick(PointerEventData eventData)
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        buyButton = transform.Find("BuyButton").gameObject.GetComponent<Button>();
        itemButtons = new Image[transform.Find("Items").transform.childCount];
        itemButtonsSelected = new bool[transform.Find("Items").transform.childCount];
        
        print(itemButtonsSelected.Length);
        for (int i = 0; i < itemButtons.Length; i++) {
            itemButtons[i] = transform.Find("Items").GetChild(i).gameObject.GetComponent<Image>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (exitHasBeenCalled == true) {
            onExit();
            exitHasBeenCalled = false;
        }
    }

    public void onBuy() {
        foreach (Image button in itemButtons) {
            button.color = new Color32(255,203,136,255);
        }
    }
    public void onExit() {
        foreach (Image button in itemButtons) {
            button.color = new Color32(255,203,136,255);
        }
    }

    public static void ExitHasBeenCalled() {
        exitHasBeenCalled = true;
    }


}
