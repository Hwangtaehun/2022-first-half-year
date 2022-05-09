using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    Rigidbody rb;
    float speed = 3.0f;
    float jumpForce = 5.0f;
    bool isJumping = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& isJumping == false)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
        TransKeycode();
    }

    void TransKeycode()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            this.transform.Rotate(0, -3.0f, 0);
        }
        else if (Input.GetKey(KeyCode.E))
        {
            this.transform.Rotate(0, 3.0f, 0);
        }
    }

    void TransVelocity()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(h, 0, v);
        rb.velocity = direction * speed;
    }

    void GetAxis()
    {
        //float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        float trans = speed = Time.deltaTime;

        this.transform.Translate(h * trans, 0, v * trans);
    }
    private void OnCollisionEnter(Collision collision)
    {
        isJumping = false;
    }
    private void OnCollisionExit(Collision collision)
    {
        isJumping = true;
    }
}
