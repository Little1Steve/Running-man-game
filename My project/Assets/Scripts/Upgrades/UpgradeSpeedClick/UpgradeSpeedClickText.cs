using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpgradeSpeedClickText : MonoBehaviour
{

    public TextMeshProUGUI counterText;
    private float counter;
    public void Update()
    {
        counter = (float)System.Math.Round(Holder.SpeedUpgradeClickCost, 2, MidpointRounding.AwayFromZero); // Takes the rounded upgrade cost and makes into text
        counterText.text = counter.ToString();
    }

}
