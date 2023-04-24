using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeSpeed : MonoBehaviour
{
    public void Onclick() // Triggers the below code when the mouse is clicked on the attached object
    {

        if(Holder.Speed >= Holder.SpeedUpgradeCost) // If the current speed amount is greater than the upgrade cost the below code will execute
        {
            Holder.SpeedPerTime += Holder.SpeedUpgradeAmount; // Executes the upgrade
            Holder.Speed -= Holder.SpeedUpgradeCost; // Decreases the current speed
            Holder.SpeedUpgradeCost *= Holder.SpeedUpgradeCostMultiplier; //Increses the cost of this upgrade

        }
        else // If the current speed is not greater than the upgrade cost it will simply end the function and effectively do nothing
        {             
            return;
        }

    }
        



}
