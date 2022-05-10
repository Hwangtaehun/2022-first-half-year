using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    GameObject obj;
    Vector3 trans;

    private void Awake()  //게임을 시작하기 전에 사용, 한번만 실행
    {

    }

    void Start()        // 업데이트 함수보다 우선적으로 시작
    {
        obj = GameObject.Find("Cube");
        //trans = obj.transform.position;
        //obj.transform.position = trans + new Vector3(1, 1, 1);
    }

    void Update()      // 너무 사용하면 용량이 커진다.
    {
        obj.transform.Translate(new Vector3(0, 0, 0.1f));
    }

    private void FixedUpadate()  //물리 연산할 때 사용한다.
    {

    }

}
