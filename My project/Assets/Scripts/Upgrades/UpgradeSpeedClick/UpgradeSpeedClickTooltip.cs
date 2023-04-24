using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class UpgradeSpeedClickTooltip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject Description;
    public TextMeshProUGUI DescriptionText;
    public RectTransform Background;

    public void SetText(string TooltipText, TextMeshProUGUI Text, RectTransform BackgroundrectTransform)
    {
        Text.SetText(TooltipText);
        Text.ForceMeshUpdate();

        Vector2 Textsize = Text.GetRenderedValues(false);
        Vector2 PaddingSize = new(8, 8);

        BackgroundrectTransform.sizeDelta = Textsize + PaddingSize;
    }

    void Update()
    {
        Vector2 curScreenPoint = new(Input.mousePosition.x, Input.mousePosition.y);
        Description.transform.position = curScreenPoint;
        SetText("Upgrade speed per click\n" + "Increases income per click\n" + "Cost: " + (float)System.Math.Round(Holder.SpeedUpgradeClickCost, 2, MidpointRounding.AwayFromZero), DescriptionText, Background);
    }


    public void OnPointerEnter(PointerEventData eventdata)
    {
        Description.SetActive(true);
    }
    public void OnPointerExit(PointerEventData eventdata)
    {
        Description.SetActive(false);

    }
}