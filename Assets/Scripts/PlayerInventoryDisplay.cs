using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventoryDisplay : MonoBehaviour
{
    public Image[] starPlaceHolders;

    public Sprite iconStarYellow;
    public Sprite iconStarGrey;

    public void OnChangeStartTotal(int startTotal)
    {
        for (int i = 0; i < starPlaceHolders.Length; i++)
        {
            if (i < startTotal)
                starPlaceHolders[i].sprite = iconStarYellow;
            else
                starPlaceHolders[i].sprite = iconStarGrey;
        }
    }
}
