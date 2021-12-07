using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class InventoryItem
{
    public enum InventoryItemType
    {
        Rock
    }

    public InventoryItemType itemType;
    public int amount;

    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:
            case InventoryItemType.Rock:    return ItemAssets.Instance.rockSprite;
        }
    }
}
