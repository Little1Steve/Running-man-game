using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeSpeed : MonoBehaviour
{
    public void Onclick() // Triggers the below code when the attached object is clicked
    {
        
        if (Holder.Coins >= System.Math.Round(Holder.CoinsPerCoinUpgradeCost, MidpointRounding.AwayFromZero)) // If the current speed amount is greater than the upgrade cost the below code will execute
        {
            Holder.CoinsPerCoin += Holder.CoinsPerCoinUpgradeAmount; // Executes the upgrade
            Holder.Coins -= System.Math.Round(Holder.CoinsPerCoinUpgradeCost, MidpointRounding.AwayFromZero); // Decreases the amount of coins held
            Holder.CoinsPerCoinUpgradeCost *= Holder.SpeedUpgradeCostMultiplier; //Increses the cost of this upgrade

        }
        else // If the current speed is not greater than the upgrade cost it will simply end the function and effectively do nothing
        {             
            return;
        }

    }
        



}
