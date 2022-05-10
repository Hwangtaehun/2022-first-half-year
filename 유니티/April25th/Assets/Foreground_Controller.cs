using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foreground_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player_mover.go_left == true)
        {
            transform.Translate(Vector3.right * 0.02f, Space.World);
        }

        else if (Player_mover.go_right == true)
        {
            transform.Translate(Vector3.left * 0.02f, Space.World);
        }
    }
}
