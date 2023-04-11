using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeSpeedClick : MonoBehaviour
{
   public void Onclick()
    {
        if (Holder.Speed > Holder.SpeedUpgradeClickCost)
        {
            Holder.SpeedPerClick += Holder.SpeedUpgradeClickAmount;
            Holder.Speed -= (int)Mathf.Round(Holder.SpeedUpgradeClickCost);
            Holder.SpeedUpgradeClickCost *= Holder.SpeedUpgradeCostMultiplier;
        }
        else
        {
            return;
        }

    }
}
