using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public bool carryingStar = false;
    public Image starImage;
    public Sprite iconStar;
    public Sprite iconNoStar;

    // Start is called just before any of the Update methods is called the first time
    void Start()
    {
        UpdateStarImage();
    }

    // OnTriggerEnter2D is called when the Collider2D other enters the trigger (2D physics only)
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Star"))
        {
            carryingStar = true;
            UpdateStarImage();
            Destroy(collision.gameObject);
        }
    }
    
    private void UpdateStarImage()
    {
        if (carryingStar)
        {
            starImage.sprite = iconStar;
        }
        else
        {
            starImage.sprite = iconNoStar;
        }
    }
}
