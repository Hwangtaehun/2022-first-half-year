using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHP : MonoBehaviour
{
    public Slider slider;
    float hp = 100;

    // Start is called before the first frame update
    void Start()
    {
        slider = GameObject.Find("HPSlider").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.name == "Fire" && slider.value > 0)
        {
            slider.value -= 1;
        }

        if (collision.gameObject.name == "Water")
        {
            if (hp > 100)
                hp = 100;
            slider.value += 1;
        }
    }
}
