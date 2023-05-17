using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedDecreaser : MonoBehaviour
{
    protected float Timer;


    void Update() // Triggers every frame
    {
        float DelayAmount = (float)Holder.SpeedDecreaseDelayTime; // Sets the interval delay
        Timer += Time.deltaTime; // Tracks real life time

        if (Timer >= DelayAmount) // Checks if the timer variable is equal to or higher than the DelayAmount variable, and if so it triggers the below code
        {
            if (Holder.Speed >= 2) // Checks if the Speed variable is equal to or higher than 2
            {
                Timer = 0f; // Resets the time to 0
                Holder.Speed /= 2;
                return;
            }
            else if(Holder.Speed >= 1) // If the above returns false, this checks if the Speed variable is equal to or higher than 1
            {
                Timer = 0f;
                Holder.Speed = 1;
                return;
            } // The above if and else if statements ensure that the Speed variable never goes under 1
        }
    }


}

