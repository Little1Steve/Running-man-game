using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeSpeedClick : MonoBehaviour
{
   public void Onclick()
    {
        if (Holder.Coins >= System.Math.Round(Holder.SpeedUpgradeClickCost, MidpointRounding.AwayFromZero))
        {
            Holder.SpeedPerClick += Holder.SpeedUpgradeClickAmount;
            Holder.Coins -= System.Math.Round(Holder.SpeedUpgradeClickCost, MidpointRounding.AwayFromZero);
            Holder.SpeedUpgradeClickCost *= Holder.SpeedUpgradeCostMultiplier;
        }
        else
        {
            return;
        }

    }
}
