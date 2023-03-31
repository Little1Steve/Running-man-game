using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class VariableText : MonoBehaviour
{
    public TextMeshProUGUI counterText;
    float counter;

    public void Update()
    {
        counter = Holder.Speed;
        counterText.text = counter.ToString();
    }
}
