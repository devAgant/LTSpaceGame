using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Inventory : MonoBehaviour
{
    private Inventory inventory;
    private Transform container;
    private Transform itemSlot;
    private PlayerInventory player;

    private void Awake()
    {
        container = transform.Find("Container");
        itemSlot = container.Find("ItemSlot");
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

    private void Inventory_OnItemListChanged(object sender, System.EventArgs e)
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
        foreach (InventoryItem item in inventory.GetItemList())
        {
            RectTransform itemSlotRectTransform = Instantiate(itemSlot, container).GetComponent<RectTransform>();
            itemSlotRectTransform.gameObject.SetActive(true);

            itemSlotRectTransform.GetComponent<Clickable>().OnLeftClick.AddListener(() =>
            {
                // to use item
                
            });
            itemSlotRectTransform.GetComponent<Clickable>().OnRightClick.AddListener(() =>
            {
                // drop item
                inventory.RemoveItem(item);
                ItemWorld.DropItem(player.GetComponent<Transform>().position, item);
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
