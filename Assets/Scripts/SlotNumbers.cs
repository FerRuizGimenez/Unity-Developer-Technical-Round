using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SlotNumbers : MonoBehaviour
{
    char[] randomNumbers = { '0' , '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    public string randomNumberSelected;

    [SerializeField] TextMeshProUGUI slotNumber;
    [SerializeField] TextMeshProUGUI timeText;
    [SerializeField] Button startAgaingBtn;

    float _time;

    Manager manager;

    private void Awake() 
    {  
        manager = FindObjectOfType<Manager>();
    }
    private void Update() 
    {
        _time = (int)(Time.timeSinceLevelLoad % 60f);
        timeText.text = _time.ToString() + " seconds";

        slotNumber.text = randomNumbers[Random.Range(0, randomNumbers.Length)].ToString();   

        if(_time >= 59)
        {
            randomNumberSelected = slotNumber.text;
            Debug.Log("num generado " + randomNumberSelected);
            StopNumber();
            manager.Selection();
            startAgaingBtn.interactable = true;
        } 

    }

    void StopNumber()
    {
        enabled = false;
    }

    public void StartAgain()
    {
        SceneManager.LoadScene("Game");
    }
}
