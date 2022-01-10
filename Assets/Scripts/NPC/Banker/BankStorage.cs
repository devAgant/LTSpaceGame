using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BankStorage
{
    public event EventHandler OnBankItemListChanged;

    private List<InventoryItem> bankItems = new List<InventoryItem>();

    public BankStorage()
    {
        bankItems = new List<InventoryItem>();

        AddItem(new InventoryItem { itemType = InventoryItem.InventoryItemType.Rock, amount = 1 });
        AddItem(new InventoryItem { itemType = InventoryItem.InventoryItemType.Rock, amount = 3 });
        Debug.Log(bankItems.Count);
    }

    public void AddItem(InventoryItem item)
    {
        bankItems.Add(item);
        OnBankItemListChanged?.Invoke(this, EventArgs.Empty);
    }

    public void RemoveItem(InventoryItem item)
    {
        bankItems.Remove(item);
        OnBankItemListChanged?.Invoke(this, EventArgs.Empty);
    }

    public List<InventoryItem> GetItemList()
    {
        return bankItems;
    }
}
