using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class UpgradeSpeedText : MonoBehaviour
{ 
    public TextMeshProUGUI counterText;
    private float counter;
    public void Update()
    {
        counter = (float)System.Math.Round(Holder.SpeedUpgradeCost, 2, MidpointRounding.AwayFromZero);
        counterText.text = counter.ToString();
    }
}
