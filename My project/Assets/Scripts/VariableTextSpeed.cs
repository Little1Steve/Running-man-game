using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VariableTextSpeed : MonoBehaviour
{
    public TextMeshProUGUI counterText;
    private float counter;
    public void Update()
    {
            counter = (float)System.Math.Round(Holder.Speed, 2, MidpointRounding.AwayFromZero); // Takes the rounded upgrade cost and makes into text
            counterText.text = counter.ToString() + " Speed";
        
    }
}
