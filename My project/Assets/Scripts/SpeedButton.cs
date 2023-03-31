using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedButton : MonoBehaviour
{
       public void Onclick()
            {
            Holder.Speed += Holder.SpeedPerClick;
        }
  
}

