using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private PlayerInventoryDisplay playerInventoryDisplay;
    private int totalStars = 0;
    
    // Start is called just before any of the Update methods is called the first time
    void Start()
    {
        playerInventoryDisplay = GetComponent<PlayerInventoryDisplay>();
    }

    // OnTriggerEnter2D is called when the Collider2D other enters the trigger (2D physics only)
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Star"))
        {
            totalStars++;
            playerInventoryDisplay.OnChangeStartTotal(totalStars);
            Destroy(collision.gameObject);
        }
    }
    
}
