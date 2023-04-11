using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class UpgradeSpeedTooltip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{ 
    public GameObject Description;
    public TextMeshProUGUI DescriptionText;
    private Vector2 screenPoint;


    void Update()
    {
        Vector2 curScreenPoint = new Vector2(Input.mousePosition.x, Input.mousePosition.y + 20);
        Description.transform.position = curScreenPoint;
        DescriptionText.text = ("Upgrade speed per tick\n" + "Increases your passive income\n" + "Cost: " + Mathf.Round(Holder.SpeedUpgradeCost));
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
