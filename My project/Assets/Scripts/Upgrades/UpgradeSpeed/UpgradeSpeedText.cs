using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using Unity.VisualScripting;
using UnityEngine.EventSystems;

public class UpgradeSpeedText : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{ 
    public TextMeshProUGUI counterText;
    private float counter;
    private bool On = false;
    
    
    public void Update()
    {
        if (On == true)
        {
            counter = (float)System.Math.Round(Holder.CoinsPerCoinUpgradeCost, MidpointRounding.AwayFromZero);
            counterText.text = "cost: " + counter.ToString();
        }
        else if (On == false)
        {
            counterText.text = "Upgrade Coin Income";
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
