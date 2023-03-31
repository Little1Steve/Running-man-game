using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedIncreaser : MonoBehaviour
{
    public int DelayAmount = Holder.SpeedDelayTime;
    protected float Timer;


   

    void Update()
    {
        Timer += Time.deltaTime;

        if (Timer >= DelayAmount)
        {
            Timer = 0f;
            Holder.Speed += Holder.SpeedPerTime ; 
        
        }
    }
}
