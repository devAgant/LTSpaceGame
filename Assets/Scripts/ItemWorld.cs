using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemWorld : MonoBehaviour
{
    public static ItemWorld SpawnItemWorld(Vector3 position, InventoryItem item)
    {
        Transform transform = Instantiate(ItemAssets.Instance.pfItemWorld, position, Quaternion.identity);

        ItemWorld itemWorld = transform.GetComponent<ItemWorld>();
        itemWorld.SetItem(item);

        return itemWorld;
    }

    public static ItemWorld DropItem(Vector3 dropPosition, InventoryItem item)
    {
        Vector3 randomDir = Random.insideUnitCircle.normalized;
        ItemWorld itemWorld = SpawnItemWorld(dropPosition + randomDir * 1.5f, item);
        return itemWorld;
    }

    private InventoryItem item;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void SetItem(InventoryItem item)
    {
        this.item = item;
        spriteRenderer.sprite = item.GetSprite();
    }

    public InventoryItem GetItem()
    {
        return item;
    }

    public void DestroySelf()
    {
        Destroy(gameObject);
    }
}
