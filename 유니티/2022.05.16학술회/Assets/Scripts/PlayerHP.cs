using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public Slider HPSlider;
    public GameObject gameOver;

    // Use this for initialization
    void Start()
    {
        gameOver.SetActive(false);
        HPSlider.value = 100;
    }

    private void Update()
    {
        if (HPSlider.value <= 0)
        {
            gameOver.SetActive(true);
        }
    }

    //Check if player enters/stays on the fire
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Fire" && HPSlider.value > 0)
        {
            HPSlider.value -= .1f;
        }
        else if(other.gameObject.name == "Water" && HPSlider.value < 100)
        {
            HPSlider.value += .1f;
        }
    }
}
