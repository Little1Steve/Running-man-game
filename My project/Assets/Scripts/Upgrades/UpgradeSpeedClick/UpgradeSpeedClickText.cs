using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class UpgradeSpeedClickText : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public TextMeshProUGUI counterText;
    private float counter;
    private bool On = false;


    public void Update()
    {
        if (On == true)
        {
            counter = (float)System.Math.Round(Holder.SpeedUpgradeClickCost, MidpointRounding.AwayFromZero);
            counterText.text = "cost: " + counter.ToString();
        }
        else if (On == false)
        {
            counterText.text = "Upgrade speed per click";
        }
    }
    public void OnPointerEnter(PointerEventData eventdata)
    {
        On = true;
    }
    public void OnPointerExit(PointerEventData eventdata)
    {
        On = false;
    }
}
