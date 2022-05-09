using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    float spead = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(spead * Time.deltaTime * -1, 0, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Time.timeScale = 0;
    }
}
