using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpgradeSpeedText : MonoBehaviour
{ 
    public TextMeshProUGUI counterText;
    private float counter;
    public void Update()
    {
        counter = (int)Mathf.Round(Holder.SpeedUpgradeCost);
        counterText.text = counter.ToString();
    }
}
