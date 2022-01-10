using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BuyHandler : MonoBehaviour, IPointerClickHandler
{
    Button buyButton;
    List<GameObject> itemButtons;
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
        itemButtons = new List<GameObject>();
        Update();
    }

    // Update is called once per frame
    void Update()
    {
        List<GameObject> tempButtons = new List<GameObject>();
        for (int i = 0; i < transform.Find("Items").transform.childCount; i++) {
            tempButtons.Add(transform.Find("Items").GetChild(i).gameObject);
        }
        if(!itemButtons.Equals(tempButtons)) {
            itemButtons = tempButtons;
        }
        if (exitHasBeenCalled == true) {
            onExit();
            exitHasBeenCalled = false;
        }
    }

    public void onBuy() {
        Merchant_UI_Inventory m = gameObject.GetComponent<Merchant_UI_Inventory>();
        MerchantItems merchantItems = m.merchantItems;
        int totalPrice = merchantItems.GetSelectedPrice();
        List<MerchantItem> items = merchantItems.GetSelectedItemList();
        if(totalPrice > m.wallet) {
            GameObject.Find("Feedback").GetComponent<Text>().text = "";
        }
        else if (items.Count == 0) {
            GameObject.Find("Feedback").GetComponent<Text>().text = "You cannot buy nothing";
        }
        else {
            m.wallet -= totalPrice;
            foreach (MerchantItem item in items) {
                item.selected = false;
                m.inventory.AddItem(item);
            }
            GameObject.Find("Feedback").GetComponent<Text>().text = "";
            foreach (GameObject button in itemButtons) {
                button.transform.GetChild(0).gameObject.GetComponent<Image>().color = new Color32(255,203,136,255);
            }
        }
    }
    public void onExit() {
        GameObject.Find("Feedback").GetComponent<Text>().text = "";
        foreach(MerchantItem item in gameObject.GetComponent<Merchant_UI_Inventory>().merchantItems.GetSelectedItemList()) {
            item.selected = false;
        }
        foreach (GameObject button in itemButtons) {
            button.transform.GetChild(0).gameObject.GetComponent<Image>().color = new Color32(255,203,136,255);
        }
    }

    public static void ExitHasBeenCalled() {
        exitHasBeenCalled = true;
    }


}
