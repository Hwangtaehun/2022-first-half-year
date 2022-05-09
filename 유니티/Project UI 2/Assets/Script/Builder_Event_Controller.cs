using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Builder_Event_Controller : MonoBehaviour
{
    public Button LevelButton;
    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        LevelButton = root.Q<Button>("button1");
        LevelButton.clicked += LevelButtonPressed;
    }
    void LevelButtonPressed()
    {
        Debug.Log("Button1 pressed.");
    }
}

