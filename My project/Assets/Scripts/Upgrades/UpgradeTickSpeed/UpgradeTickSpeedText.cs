using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpgradeTickSpeedText : MonoBehaviour
{
    public TextMeshProUGUI counterText;
    private float counter;
    public void Update()
    {
        counter = (float)System.Math.Round(Holder.TickSpeedUpgradeCost, 2, MidpointRounding.AwayFromZero);
        counterText.text = counter.ToString();
    }
}