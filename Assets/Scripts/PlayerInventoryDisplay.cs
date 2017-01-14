using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventoryDisplay : MonoBehaviour
{
    public Text inventoryText;

    internal void OnChangeInventory(List<Pickup> inventory)
    {
        //setting the items in alphabetical sorting
        inventory.Sort(
            delegate (Pickup p1, Pickup p2)
            {
                return p1.description.CompareTo(p2.description);
            }
            );

        // clear display
        inventoryText.text = "";

        //build up new set of items
        string newInventoryText = "carrying: ";
        int numItems = inventory.Count;
        for (int i = 0; i < numItems; i++)
        {
            string description = inventory[i].description;
            newInventoryText += " [" + description + "]";
        }
        if (numItems < 1) newInventoryText = "(empty inventory)";
        {
            // update screen display
            inventoryText.text = newInventoryText;
        }
    }
}
