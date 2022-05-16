using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameracontroller : MonoBehaviour
{
    GameObject player;
    public float offsetX = 0;
    public float offsetY = 0;
    public float offsetZ = 0;

    Vector3 camPos;
    public float camSpeed = 5.0f;

    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        camPos.x = player.transform.position.x + offsetX;
        camPos.y = player.transform.position.y + offsetY;
        camPos.z = player.transform.position.z + offsetZ;

        this.transform.rotation = Quaternion.Euler(10.0f, 0, 0);
        //this.transform.position = camPos;
        this.transform.position = Vector3.Lerp(transform.position, camPos, camSpeed * Time.deltaTime);
    }
}
