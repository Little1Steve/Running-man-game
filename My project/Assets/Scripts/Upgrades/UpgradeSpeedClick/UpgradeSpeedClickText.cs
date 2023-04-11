using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpgradeSpeedClickText : MonoBehaviour
{

    public TextMeshProUGUI counterText;
    private float counter;
    public void Update()
    {
        counter = (int)Mathf.Round(Holder.SpeedUpgradeClickCost); //Takes the rounded upgrade cost and makes into text
        counterText.text = counter.ToString();
    }

}
