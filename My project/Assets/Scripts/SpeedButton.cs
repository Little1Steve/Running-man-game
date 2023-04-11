using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedButton : MonoBehaviour
{
       public void Onclick()
            {
            Holder.Speed += Holder.SpeedPerClick; //Increases the total amount of speed when the attached button is clicked
        }
  
}

