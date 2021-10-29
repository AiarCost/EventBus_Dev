using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour
{

    private bool m_isQuitting;
    private bool m_IsLaunched = false;


    private void OnEnable()
    {
        EventBus.StartListening("Hide", Hiding);
    }

    void OnApplicationQuit()
    {
        m_isQuitting = true;
    }

    private void OnDisable()
    {
        if (m_isQuitting == false)
        {
            EventBus.StopListening("Hide", Hiding);
        }
    }

    void Hiding()
    {
        if (m_IsLaunched == false)
        {
            m_IsLaunched = true;
            Debug.Log("Recieved a Hide event : Item is now Hidden!");
        }
    }
}
