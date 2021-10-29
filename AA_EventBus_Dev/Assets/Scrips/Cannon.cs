using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{

    private bool m_isQuitting;


    private void OnEnable()
    {
        EventBus.StartListening("Shoot", Shoot);
    }

    void OnApplicationQuit()
    {
        m_isQuitting = true;
    }

    private void OnDisable()
    {
        if (m_isQuitting == false)
        {
            EventBus.StopListening("Shoot", Shoot);
        }
    }

    void Shoot()
    {
            Debug.Log("Recieved a Shoot event : Shooting cannon!");
        
    }
}