using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Merchant_UI_Inventory : MonoBehaviour
{
    public MerchantItems merchantItems {
        get;
        private set;
    }

    private Transform container;
    private Transform itemSlot;
    public Inventory inventory; // temporary, will become PlayerInventory when merchant scene joins rest of the game
    public int wallet = 500; // also temp

    void Start()
    {
        inventory = new Inventory();
        container = transform.Find("Items");
        itemSlot = container.Find("ItemSlot");
        SetMerchantItems(new MerchantItems());
    }

    void Update() 
    {
        int price = merchantItems.GetSelectedPrice();
        if (!GameObject.Find("PriceInfo").GetComponent<Text>().text.Equals("Price: " + price))
        {
            GameObject.Find("PriceInfo").GetComponent<Text>().text = "Price: " + price;
        }
        if (!GameObject.Find("WalletInfo").GetComponent<Text>().text.Equals("Wallet: " + wallet))
        {
            GameObject.Find("WalletInfo").GetComponent<Text>().text = "Wallet: " + wallet;
        }
    }

    /*
    public void SetPlayer(PlayerInventory player)
    {
        this.player = player;
    }
    */

    public void SetMerchantItems(MerchantItems merchantItems)
    {
        this.merchantItems = merchantItems;
        merchantItems.OnMerchantItemListChanged += Merchant_OnMerchantItemListChanged;
        RefreshItems();
    }

    private void Merchant_OnMerchantItemListChanged(object sender, System.EventArgs e)
    {
        RefreshItems();
    }

    private void RefreshItems()
    {
        foreach (Transform child in container)
        {
            if (child == itemSlot) continue;
            Destroy(child.gameObject);
        }
        int x = 0;
        int y = 0;
        float itemSlotCellSize = 80f;
        float margin = 10f;
        foreach (MerchantItem item in merchantItems.GetItemList())
        {
            RectTransform itemSlotRectTransform = Instantiate(itemSlot, container).GetComponent<RectTransform>();
            itemSlotRectTransform.gameObject.SetActive(true);

            itemSlotRectTransform.GetComponent<Clickable>().OnLeftClick.AddListener(() =>
            {
                if (itemSlotRectTransform.GetChild(0).gameObject.GetComponent<Image>().color == Color.green)
                {
                    item.selected = false;
                    itemSlotRectTransform.GetChild(0).gameObject.GetComponent<Image>().color = new Color32(255,203,136,245);
                }
                else
                {
                    item.selected = true;
                    itemSlotRectTransform.GetChild(0).gameObject.GetComponent<Image>().color = Color.green;
                }
            });
            
            
            itemSlotRectTransform.anchoredPosition = new Vector2(x * (itemSlotCellSize + margin), -y * (itemSlotCellSize + margin));
            Image image = itemSlotRectTransform.GetChild(1).gameObject.GetComponent<Image>();
            image.sprite = item.GetSprite();
            x++;
            if (x == 2)
            {
                x = 0;
                y++;
            }
        }
    }
}
