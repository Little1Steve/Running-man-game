using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class VariableText : MonoBehaviour
{
    public TextMeshProUGUI counterText;
    private float counter;
    public void Update()
    {

        if (Holder.Coins == 1)
        {
            counter = (float)System.Math.Round(Holder.Coins, 2, MidpointRounding.AwayFromZero); // Takes the rounded upgrade cost and makes into text
            counterText.text = counter.ToString() + " Coin";
        }
        else {
            counter = (float)System.Math.Round(Holder.Coins, 2, MidpointRounding.AwayFromZero); // Takes the rounded upgrade cost and makes into text
            counterText.text = counter.ToString() + " Coins";
        }
    }

}
