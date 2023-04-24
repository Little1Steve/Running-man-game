using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigUpgrade : MonoBehaviour
{
   public void Onclick()
    {
        if(Holder.Speed >= Holder.BigUpgradeCost)
        {
            Holder.SpeedPerClick *= Holder.BigUpgradeAmount;
            Holder.SpeedPerTime *= Holder.BigUpgradeAmount;
            Holder.SpeedUpgradeAmount *= Holder.BigUpgradeAmount;
            Holder.SpeedUpgradeClickAmount *= Holder.BigUpgradeAmount;
            Holder.Speed -= (Holder.BigUpgradeCost); 
            Holder.BigUpgradeCost *= Holder.BigUpgradeCostMultiplier;

        }
        else
        {
            return;
        }

    }
}
