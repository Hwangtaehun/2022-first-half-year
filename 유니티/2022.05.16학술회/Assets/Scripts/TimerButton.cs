using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerButton : MonoBehaviour
{
    private Timer timer;
    private TextMeshProUGUI buttonText;

    // Start is called before the first frame update
    void Start()
    {
        timer = GameObject.FindObjectOfType<Timer>();
        buttonText = GetComponentInChildren<TextMeshProUGUI>();
    }

    public void StartTimer()
    {
        timer.time = 11f;
        Timer.isOver = false;
        buttonText.text = "Restart";
    }
}
