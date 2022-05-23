using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerBtn : MonoBehaviour
{
    Timer timer;
    
    void Start()
    {
        timer = FindObjectOfType<timer>().GetComponent<timer>();
    }

    void Restart()
    {
        timer.SetTime(10);
    }
}
