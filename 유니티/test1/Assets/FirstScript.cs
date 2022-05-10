using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    public int a = 10;
    public int b = 20;

    // c# 배열 for문의 순회
    int[] c = { 1, 2, 3, 4, 5 };

    void Awake()
    {
        //foreach(int i in c)
        //{
        //    Debug.Log(i);
        //}

        for (int k = 0; k < 5; k++)
        {
            Debug.Log(k);
        }
    }

    private void OnEnable()
    {
        Debug.Log("hi I am OnEnable" );
    }

    void Start()
    {
        Debug.Log("Hello world");
    }

    private void OnDisable()
    {
        Debug.Log("hi I am OnDisable");
    }

    private void OnMouseDown()
    {
        Debug.Log("hi I am OnMouseDown");
    }

    private void OnMouseDrag()
    {
        Debug.Log("hi I am OnMouseDrag");
    }

    // Update is called once per frame
    //private void Update()
    //{
    //    print(Time.deltaTime);
    //    Debug.Log(a + b);
    //}

    //private void FixedUpdate()
    //{
    //    //업데이터 간격 시간
    //    print(Time.deltaTime);
    //}
}
