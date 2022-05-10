using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_mover : MonoBehaviour
{
    public static bool go_left = false;
    public static bool go_right = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        go_left = false;
        go_right = false;

        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            go_left = true;

            transform.Translate(Vector3.left * 0.1f, Space.World);
        }

        else if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            go_right = true;

            transform.Translate(Vector3.right * 0.1f, Space.World);
        }

        else if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            //transform.Translate(Vector3.up * 0.1f, Space.World);
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 2);
        }
    }
}
