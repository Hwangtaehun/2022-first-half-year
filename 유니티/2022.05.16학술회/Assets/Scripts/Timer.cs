using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private TextMeshProUGUI timerText;
    public float time;
    private int currentTime = 0;
    public static bool isOver = true;

    private void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        if(isOver == false)
        {
            time -= Time.deltaTime;
            currentTime = (int)time;
            if (currentTime < 0)
            {
                currentTime = 0;
                isOver = true;
            }
            timerText.text = "Timer :" + currentTime;
        }
    }
}
