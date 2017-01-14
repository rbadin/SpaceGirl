using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour {

    private PlayerInventoryDisplay playerInventoryDisplay;
    private Dictionary<Pickup.PickUpType, int> items = new Dictionary<Pickup.PickUpType, int>();


     // Start is called just before any of the Update methods is called the first time
     void Start()
    {
        playerInventoryDisplay = GetComponent<PlayerInventoryDisplay>();
        playerInventoryDisplay.OnChangeInventory(items);
    }

    public void Add(Pickup pickup)
    {
        Pickup.PickUpType type = pickup.type;
        int oldTotal = 0;
        if (items.TryGetValue(type, out oldTotal))
        {
            items[type] = oldTotal + 1;
        }
        else
        {
            items.Add(type, 1);
        }

        playerInventoryDisplay.OnChangeInventory(items);
    }
}
