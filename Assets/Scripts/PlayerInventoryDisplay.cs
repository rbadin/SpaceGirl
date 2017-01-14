using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventoryDisplay : MonoBehaviour
{
    public Text inventoryText;

    public void OnChangeInventory(Dictionary<Pickup.PickUpType, int> inventory)
    {
        // clear display
        inventoryText.text = "";

        //build up new set of items
        string newInventoryText = "carrying: ";
        int numItems = inventory.Count;

        foreach (var item in inventory)
        {
            int itemTotal = item.Value;
            string description = item.Key.ToString();
            newInventoryText += " [" + description + " x " + itemTotal + " ]";
        }
        if (numItems < 1) newInventoryText = "(empty inventory)";

        inventoryText.text = newInventoryText;
    }
}
