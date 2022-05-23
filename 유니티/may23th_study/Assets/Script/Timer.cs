using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    TextMeshProUGUI timer;
    bool isOver = false;
    float time = 10.0f;

    void Start()
    {
        timer = GameObject.Find("Timer").GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        if(isOver == false)
        {
            if (time <= 0)
                isOver = true;

            time -= Time.deltaTime;
            int currentTime = (int)time;

            timer.text = "Timer: "+ currentTime.ToString();
        }
    }

    void setIsover(bool set)
    {
        isOver = set;
    }

    bool GetIsOver()
    {
        return isOver; 
    }

    public float SetTime(float time)
    {
        this.time = time;
    }
}
