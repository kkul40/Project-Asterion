using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestRunner
{
    [Test]
    public void InventoryAddRemoveTest()
    {
        // GameObject player = new GameObject();
        //
        // player.AddComponent<Inventory>();
        //
        // ItemData itemData = ScriptableObject.CreateInstance<ItemData>();
        //
        // player.GetComponent<Inventory>().AddItem(itemData);
        //
        //
        // //Assert.AreEqual(itemData, inventory.GetInventory[0].itemData);
        // Assert.AreEqual(2, player.GetComponent<Inventory>().GetInventory[0].stock);
        // Debug.Log("Test");

    }

    [Test]
    public void TestRunnerTest()
    {
        Assert.AreEqual(3,3);
    }
    
}
