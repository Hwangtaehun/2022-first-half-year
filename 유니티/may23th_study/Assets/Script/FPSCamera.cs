using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCamera : MonoBehaviour
{
    GameObject player;

    public float sensitivity = 100f; // ���콺 ����
    float rotX;
    float rotY;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = player.transform.position + new Vector3(0, 1.5f, 0);
        RotateCamera();
    }

    void RotateCamera()
    {
        // ���콺�� ��ġ�� �޾ƿ���
        float x = Input.GetAxis("Mouse X"); // ���콺 �¿� ������ ����
        float y = Input.GetAxis("Mouse Y"); // ���콺 ���� ������ ����

        // ������ �°� ī�޶� ȸ���� ���
        rotX += x * sensitivity * Time.deltaTime;   // ���콺�� �¿�: �θ����θ���
        rotY += y * sensitivity * Time.deltaTime;   // ���콺�� ���Ʒ� : ��������

        // ī�޶� ȸ�� ����
        if (rotY > 50)
            rotY = 50;
        else if (rotY < -50)
            rotY = -50;
       
        transform.eulerAngles = new Vector3(-rotY, rotX, 0f);
    }
}
