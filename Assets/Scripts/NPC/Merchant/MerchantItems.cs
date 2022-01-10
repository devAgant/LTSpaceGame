using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MerchantItems
{
    public event EventHandler OnMerchantItemListChanged;

    private List<MerchantItem> merchantItems = new List<MerchantItem>();

    public MerchantItems()
    {
        merchantItems = new List<MerchantItem>();

        AddItem(new MerchantItem { itemType = InventoryItem.InventoryItemType.Rock, amount = 1, price = 10 });
        AddItem(new MerchantItem { itemType = InventoryItem.InventoryItemType.Rock, amount = 3, price = 30 });
        Debug.Log(merchantItems.Count);
    }

    public void AddItem(MerchantItem item)
    {
        merchantItems.Add(item);
        OnMerchantItemListChanged?.Invoke(this, EventArgs.Empty);
    }

    public void RemoveItem(MerchantItem item)
    {
        merchantItems.Remove(item);
        OnMerchantItemListChanged?.Invoke(this, EventArgs.Empty);
    }

    public List<MerchantItem> GetItemList()
    {
        return merchantItems;
    }

    public List<MerchantItem> GetSelectedItemList() 
    {
        return merchantItems.FindAll(item => item.selected);
    }

    public int GetSelectedPrice()
    {
        int totalPrice = 0;
        GetSelectedItemList().ForEach(item => totalPrice += item.price);
        return totalPrice;
    }
}
