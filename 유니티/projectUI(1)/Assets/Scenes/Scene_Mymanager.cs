using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene_Mymanager : MonoBehaviour
{
    public static bool bCheck_Box = true;
    public static int bHardware = 0;
    public Slider slider_value;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void update_checkbox()
    {
        if(bCheck_Box == true)
        {
            bCheck_Box = false;
        }
        else if (bCheck_Box == false)
        {
            bCheck_Box = true;
        }
        Debug.Log("checkbox value is changed" + bCheck_Box);
    }

    public void Checkbox_OpenGL()
    {
        bHardware = 1;
        Debug.Log("OpenGl" + bHardware);
    }

    public void Checkbox_DX()
    {
        bHardware = 2;
        Debug.Log("DX" + bHardware);
    }

    public void MySlider()
    {
        Debug.Log("Slider Value:" + slider_value.value);
    }
}
