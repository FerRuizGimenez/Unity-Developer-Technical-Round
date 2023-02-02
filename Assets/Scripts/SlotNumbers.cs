using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class SlotNumbers : MonoBehaviour
{
    char[] randomNumbers = { '0' , '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    public string randomNumberSelected;

    [SerializeField] TextMeshProUGUI slotNumber;
    [SerializeField] TextMeshProUGUI timeText;

    float _time;

    private void Awake() 
    {
        randomNumberSelected = slotNumber.text;    
    }
    private void Update() 
    {
        _time = (int)(Time.timeSinceLevelLoad % 60f);
        timeText.text = _time.ToString() + " seconds";

        slotNumber.text = randomNumbers[Random.Range(0, randomNumbers.Length)].ToString();   

        if(_time == 5)
        {
            StopNumber();
            randomNumberSelected = slotNumber.text;
        } 

        //Debug.Log(randomNumberSelected);
        //Debug.Log(_time);
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
