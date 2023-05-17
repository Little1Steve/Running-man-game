using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeSpeedClick : MonoBehaviour
{
   public void Onclick()
    {
        if (Holder.Coins >= Holder.SpeedUpgradeClickCost)
        {
            Holder.SpeedPerClick += Holder.SpeedUpgradeClickAmount;
            Holder.Coins -= Holder.SpeedUpgradeClickCost;
            Holder.SpeedUpgradeClickCost *= Holder.SpeedUpgradeCostMultiplier;
        }
        else
        {
            return;
        }

    }
}
