using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedButton : MonoBehaviour
{
       public void Onclick() // Triggers the below code when the attached object is clicked
    {
            Holder.Speed += Holder.SpeedPerClick; //Increases the total amount of speed when the attached button is clicked
        }
  
}

