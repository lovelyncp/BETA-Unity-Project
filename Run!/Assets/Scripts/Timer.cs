using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float currentTime = 0f;
    private float startTime = 60f;
    public Text countdownText;

    void Start()
    {
        currentTime = startTime;
    }

    void Update()
    {
        //dicriment timer by 1 and deltaTime
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("00s");

        // when timer is finished, keep timer at 0
        if (currentTime <= 0)
        {
            currentTime = 0;
        }
    }
}
