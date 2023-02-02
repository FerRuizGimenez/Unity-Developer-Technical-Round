using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Manager : MonoBehaviour
{
    SlotNumbers slotNumber;
    NumberSelected numberSelected;

    [SerializeField] GameObject winText;
    [SerializeField] GameObject loseText;

    private void Awake() 
    {
        slotNumber = FindObjectOfType<SlotNumbers>();
        numberSelected = FindObjectOfType<NumberSelected>();    
    }

    public void Selection() 
    {
        if(slotNumber.randomNumberSelected == numberSelected.clickedBtnName)
        {
            Debug.Log("You Win");
            winText.SetActive(true);
        }   
        else
        {
            loseText.SetActive(true);
        } 
    }
}
