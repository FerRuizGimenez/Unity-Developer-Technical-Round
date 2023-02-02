using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class NumberSelected : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI selectedNumer;
    [SerializeField] List<Button> _buttons = new List<Button>();

    public string clickedBtnName;

    public void SelectNumber()
    {
        clickedBtnName = EventSystem.current.currentSelectedGameObject.name;
        Debug.Log("Boton click " + clickedBtnName);

        foreach (Button buttons in _buttons)
        {
            buttons.interactable = false;       
        }
    }

    private void Update() 
    {
        switch(clickedBtnName)
        {
            case "0":
                selectedNumer.text = "0";
                break;
            case "1":
                selectedNumer.text = "1";
                break;
            case "2":
                selectedNumer.text = "2";
                break;
            case "3":
                selectedNumer.text = "3";
                break;
            case "4":
                selectedNumer.text = "4";
                break;
            case "5":
                selectedNumer.text = "5";
                break;
            case "6":
                selectedNumer.text = "6";
                break;
            case "7":
                selectedNumer.text = "7";
                break;
            case "8":
                selectedNumer.text = "8";
                break;
            case "9":
                selectedNumer.text = "9";
                break;
        }
    }

}
