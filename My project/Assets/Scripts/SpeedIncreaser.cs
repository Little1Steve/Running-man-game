using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedIncreaser : MonoBehaviour
{
    
    protected float Timer;
   

    void Update() // Triggers every frame
    {
        float DelayAmount = (float)Holder.SpeedIncreaseDelayTime; // Sets the interval delay
        Timer += Time.deltaTime; // Tracks real life time

        if (Timer >= DelayAmount)
        {
            Timer = 0f; // Resets the time to 0
            Holder.Speed += Holder.SpeedPerTime; // Increases speed by variable amount
            Debug.Log((float)Holder.SpeedIncreaseDelayTime);
        }
    }
}
