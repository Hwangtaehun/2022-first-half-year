using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Event_Test : MonoBehaviour
{
    public UnityEvent Explosion_Event;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Explosion();
        }
    }

    private void Explosion()
    {
        Explosion_Event.Invoke();
        Debug.Log("ÆøÆÈ¹ß»ý!");
    }
}
