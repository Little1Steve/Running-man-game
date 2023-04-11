using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class UpgradeSpeedClickTooltip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{ 
    public GameObject Description;
    public TextMeshProUGUI DescriptionText;
    private Vector2 screenPoint;
    void Update()
    {
        Vector2 curScreenPoint = new Vector2(Input.mousePosition.x, Input.mousePosition.y + 20); // Tracks the mouse
        Description.transform.position = curScreenPoint;
        DescriptionText.text = ("Upgrade speed per click\n" + "Increases your income per click\n" + "Cost: " + Mathf.Round(Holder.SpeedUpgradeCost));
    }
    public void OnPointerEnter(PointerEventData eventdata)
    {
        Description.SetActive(true); // Sets the text element as active when the mouse enters the attached object
    }
    public void OnPointerExit(PointerEventData eventdata)
    {
        Description.SetActive(false); // Sets the text element as unactive when the mouse leaves the attached object

    }
}

