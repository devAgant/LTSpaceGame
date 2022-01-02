using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    public event EventHandler OnItemListChanged;

    private List<InventoryItem> inventoryItems = new List<InventoryItem>();

    public Inventory()
    {
        inventoryItems = new List<InventoryItem>();

        AddItem(new InventoryItem { itemType = InventoryItem.InventoryItemType.Rock, amount = 1 });
        AddItem(new InventoryItem { itemType = InventoryItem.InventoryItemType.Rock, amount = 3 });
        Debug.Log(inventoryItems.Count);
    }

    public void AddItem(InventoryItem item)
    {
        inventoryItems.Add(item);
        OnItemListChanged?.Invoke(this, EventArgs.Empty);
    }

    public void RemoveItem(InventoryItem item)
    {
        inventoryItems.Remove(item);
        OnItemListChanged?.Invoke(this, EventArgs.Empty);
    }

    public List<InventoryItem> GetItemList()
    {
        return inventoryItems;
    }
}
