using UnityEngine;

public class Rocket : MonoBehaviour
{

    private bool m_isQuitting;
    private bool m_IsLaunched = false;


    private void OnEnable()
    {
        EventBus.StartListening("Launch", Launch);
    }

    void OnApplicationQuit()
    {
        m_isQuitting = true;
    }

    private void OnDisable()
    {
        if(m_isQuitting == false)
        {
            EventBus.StopListening("Launch", Launch);
        }
    }

    void Launch()
    {
        if (m_IsLaunched == false)
        {
            m_IsLaunched = true;
            Debug.Log("Recieved a launch event : rocket launching!");
        }
    }
}
