using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject wallprefab;
    public float interval;

    private IEnumerator Start()
    {
        while (true)
        {
            Instantiate(wallprefab, transform.position, transform.rotation);

            yield return new WaitForSeconds(interval);
        }
    }
}
