using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bank_UI_Inventory : MonoBehaviour
{
    private Inventory inventory;
    private BankStorage bankStorage;
    private Transform container;
    private Transform bankContainer;
    private Transform itemSlot;
    private PlayerInventory player;

    private void Awake()
    {
        container = transform.Find("YourItems");
        bankContainer = transform.Find("BankerItems");
        itemSlot = container.Find("ItemSlot");
        SetInventory(new Inventory());
        SetBankStorage(new BankStorage());
    }

    public void SetPlayer(PlayerInventory player)
    {
        this.player = player;
    }

    public void SetInventory(Inventory inventory)
    {
        this.inventory = inventory;
        inventory.OnItemListChanged += Inventory_OnItemListChanged;
        RefreshItems();
    }

    public void SetBankStorage(BankStorage bankStorage)
    {
        this.bankStorage = bankStorage;
        bankStorage.OnBankItemListChanged += Bank_OnBankItemListChanged;
        RefreshBankItems();
    }

    private void Inventory_OnItemListChanged(object sender, System.EventArgs e)
    {
        RefreshItems();
    }

    private void Bank_OnBankItemListChanged(object sender, System.EventArgs e)
    {
        RefreshBankItems();
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
        foreach (InventoryItem item in inventory.GetItemList())
        {
            RectTransform itemSlotRectTransform = Instantiate(itemSlot, container).GetComponent<RectTransform>();
            itemSlotRectTransform.gameObject.SetActive(true);

            itemSlotRectTransform.GetComponent<Clickable>().OnLeftClick.AddListener(() =>
            {
                if (itemSlotRectTransform.parent.name.Equals("YourItems"))
                {
                    itemSlotRectTransform.SetParent(GameObject.Find("BankerItems").transform);
                    BankHandler.AddItem(item);
                    inventory.RemoveItem(item);
                }
                else if(itemSlotRectTransform.parent.name.Equals("BankerItems"))
                {
                    itemSlotRectTransform.SetParent(GameObject.Find("YourItems").transform);
                    inventory.AddItem(item);
                    BankHandler.RemoveItem(item);
                }
            });
            
            
            itemSlotRectTransform.anchoredPosition = new Vector2(x * (itemSlotCellSize + margin), -y * (itemSlotCellSize + margin));
            Image image = itemSlotRectTransform.Find("Image").GetComponent<Image>();
            image.sprite = item.GetSprite();
            x++;
            if (x == 2)
            {
                x = 0;
                y++;
            }
        }
    }

    private void RefreshBankItems()
    {
        foreach (Transform child in bankContainer)
        {
            if (child == itemSlot) continue;
            Destroy(child.gameObject);
        }
        int x = 0;
        int y = 0;
        float itemSlotCellSize = 80f;
        float margin = 10f;
        foreach (InventoryItem item in inventory.GetItemList())
        {
            RectTransform itemSlotRectTransform = Instantiate(itemSlot, bankContainer).GetComponent<RectTransform>();
            itemSlotRectTransform.gameObject.SetActive(true);

            itemSlotRectTransform.GetComponent<Clickable>().OnLeftClick.AddListener(() =>
            {
                if (itemSlotRectTransform.parent.name.Equals("YourItems"))
                {
                    itemSlotRectTransform.SetParent(GameObject.Find("BankerItems").transform);
                    BankHandler.AddItem(item);
                    inventory.RemoveItem(item);
                }
                else if(itemSlotRectTransform.parent.name.Equals("BankerItems"))
                {
                    itemSlotRectTransform.SetParent(GameObject.Find("YourItems").transform);
                    inventory.AddItem(item);
                    BankHandler.RemoveItem(item);
                }
            });
            
            
            itemSlotRectTransform.anchoredPosition = new Vector2(x * (itemSlotCellSize + margin), -y * (itemSlotCellSize + margin));
            Image image = itemSlotRectTransform.Find("Image").GetComponent<Image>();
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
