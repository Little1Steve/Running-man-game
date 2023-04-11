using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedIncreaser : MonoBehaviour
{
    int DelayAmount = Holder.SpeedDelayTime; // Sets the interval delay
    protected float Timer;


   

    void Update()
    {
        Timer += Time.deltaTime; // Tracks real life time

        if (Timer >= DelayAmount)
        {
            Timer = 0f; // Resets the time to 0
            Holder.Speed += Holder.SpeedPerTime ; // Increases speed by variable amount
        
        }
    }
}
