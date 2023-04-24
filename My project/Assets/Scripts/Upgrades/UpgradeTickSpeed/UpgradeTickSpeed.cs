using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeTickSpeed : MonoBehaviour
{
    public void Onclick() // Triggers the below code when the mouse is clicked on the attached object
    {

        if (Holder.Speed >= Holder.TickSpeedUpgradeCost) // If the current speed amount is greater than the upgrade cost the below code will execute
        {
            Holder.SpeedIncreaseDelayTime *= Holder.TickSpeedUpgradeAmount; // Executes the upgrade
            Holder.Speed -= Holder.TickSpeedUpgradeCost; // Decreases the current speed
            Holder.TickSpeedUpgradeCost *= Holder.SpeedUpgradeCostMultiplier; //Increses the cost of this upgrade

        }
        else // If the current speed is not greater than the upgrade cost it will simply end the function and effectively do nothing
        {
            return;
        }

    }




}
