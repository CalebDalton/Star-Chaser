using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TimerCountdown : MonoBehaviour
{
    public TMP_Text textDisplay;
    public int secondsLeft = 30;
    public bool takingAway = false;

    void Start()
    {
        textDisplay.GetComponent<TMP_Text>().text = "" + secondsLeft;
    }

    void Update()
    {
        if(takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimerTake());
        }
        
        if(secondsLeft == 0)
        {
            SceneManager.LoadScene("FinalScore");
        }
    }

    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        
        if(secondsLeft < 10)
            textDisplay.GetComponent<TMP_Text>().text = "0" + secondsLeft;
        else
            textDisplay.GetComponent<TMP_Text>().text = "" + secondsLeft;
        
        takingAway = false;
    }
}
