using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeSpeed : MonoBehaviour
{
    public void Onclick()
    {

        if(Holder.Speed >= Holder.SpeedUpgradeCost)
        {
            Holder.SpeedPerTime += Holder.SpeedUpgradeAmount;
            Holder.Speed -= (int)Mathf.Round(Holder.SpeedUpgradeCost);
            Holder.SpeedUpgradeCost *= Holder.SpeedUpgradeCostMultiplier;


        }

    }
        



}
