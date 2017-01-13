using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Text startText;
    public bool carryingStar = false;

    // Start is called just before any of the Update methods is called the first time
    void Start()
    {
        UpdateStarText();
    }

    // OnTriggerEnter2D is called when the Collider2D other enters the trigger (2D physics only)
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Star"))
        {
            carryingStar = true;
            UpdateStarText();
            Destroy(collision.gameObject);
        }
    }
    
    private void UpdateStarText()
    {
        string starMessage = "no star :=(";
        if (carryingStar) starMessage = "Carring star :-)";
        startText.text = starMessage;
    }
}
