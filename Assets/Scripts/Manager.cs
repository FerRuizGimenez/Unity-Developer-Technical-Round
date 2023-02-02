using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    SlotNumbers slotNumber;
    NumberSelected numberSelected;

    private void Awake() 
    {
        slotNumber = FindObjectOfType<SlotNumbers>();
        numberSelected = FindObjectOfType<NumberSelected>();    
    }

    private void Update() 
    {
        if(slotNumber.randomNumberSelected == numberSelected.clickedBtnName)
        {
            Debug.Log("You Win");

        }   
        else
        {
            //Debug.Log("LOSE");
        } 
    }
}
