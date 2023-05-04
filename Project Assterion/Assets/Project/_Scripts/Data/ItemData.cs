using UnityEngine;

[CreateAssetMenu(menuName = "Item Data", fileName = "New Item Data")]
public class ItemData : ScriptableObject
{
    public int ID;
    public string itemName;

    [TextArea(3, 3)] public string description;
}