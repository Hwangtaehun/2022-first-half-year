using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class UI_ManagerScript : MonoBehaviour
{
    public TMP_InputField Name_Input;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MyButton()
    {
        Debug.Log("Butoon is Pressed");
        SceneManager.LoadScene(1);
    }

    public void MyInputField_Name()
    {
        Debug.Log("�̸��� �Է��߽��ϴ�.");
        if(Name_Input.text == "KANG")
        {
            Debug.Log("�����ϴ� ID�Դϴ�.");
        }

    }
}
