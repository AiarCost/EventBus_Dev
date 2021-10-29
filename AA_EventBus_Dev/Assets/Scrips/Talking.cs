using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talking : MonoBehaviour
{

    private bool m_isQuitting;
    private bool m_IsLaunched = false;


    private void OnEnable()
    {
        EventBus.StartListening("Talk", Talk);
    }

    void OnApplicationQuit()
    {
        m_isQuitting = true;
    }

    private void OnDisable()
    {
        if (m_isQuitting == false)
        {
            EventBus.StopListening("Talk", Talk);
        }
    }

    void Talk()
    {
        if (m_IsLaunched == false)
        {
            m_IsLaunched = true;
            Debug.Log("Recieved a Talk event : Quest Given!");
        }
    }
}
