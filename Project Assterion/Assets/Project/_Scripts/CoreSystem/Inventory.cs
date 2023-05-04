using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private List<InventoryItem> _inventorySlots;

    private void Start()
    {
        _inventorySlots = new List<InventoryItem>();
    }


    public void AddItem(ItemData itemData)
    {
        var hasItem = false;

        for (var i = 0; i < _inventorySlots.Count; i++)
            if (_inventorySlots[i].itemData == itemData)
            {
                _inventorySlots[i].AddToStock();
                hasItem = true;
                break;
            }

        if (!hasItem)
        {
            var inventoryItem = new InventoryItem(itemData);
            _inventorySlots.Add(inventoryItem);
        }
    }

    public void RemoveItem(ItemData itemData)
    {
        if (_inventorySlots.Count == 0)
            return;

        for (var i = _inventorySlots.Count - 1; i >= 0; i--)
            if (_inventorySlots[i].itemData == itemData)
            {
                _inventorySlots[i].RemoveFromStock();

                if (_inventorySlots[i].stock <= 0) _inventorySlots.RemoveAt(i);

                break;
            }
    }
}