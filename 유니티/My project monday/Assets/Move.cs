using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    GameObject obj;
    Vector3 trans;

    private void Awake()  //������ �����ϱ� ���� ���, �ѹ��� ����
    {

    }

    void Start()        // ������Ʈ �Լ����� �켱������ ����
    {
        obj = GameObject.Find("Cube");
        //trans = obj.transform.position;
        //obj.transform.position = trans + new Vector3(1, 1, 1);
    }

    void Update()      // �ʹ� ����ϸ� �뷮�� Ŀ����.
    {
        obj.transform.Translate(new Vector3(0, 0, 0.1f));
    }

    private void FixedUpadate()  //���� ������ �� ����Ѵ�.
    {

    }

}
