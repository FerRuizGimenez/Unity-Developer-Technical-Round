using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SlotNumbers : MonoBehaviour
{
    char[] randomNumbers = { '0' , '1', '2', '3', '4', '5', '6', '7', '8', '9' };

    [SerializeField] TextMeshProUGUI slotNumber;

    private void Update() 
    {
        slotNumber.text = randomNumbers[Random.Range(0, randomNumbers.Length)].ToString();    
    }
}
