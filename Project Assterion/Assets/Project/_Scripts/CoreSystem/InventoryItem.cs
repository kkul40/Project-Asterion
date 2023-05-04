using System;

[Serializable]
public class InventoryItem
{
    public ItemData itemData;
    public int stock;

    public InventoryItem(ItemData itemData)
    {
        this.itemData = itemData;
        AddToStock();
    }

    public void AddToStock()
    {
        stock++;
    }

    public void RemoveFromStock()
    {
        stock--;
    }
}