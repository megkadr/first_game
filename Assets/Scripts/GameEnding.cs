using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnding : MonoBehaviour
{
    public float fadeDuration = 1f;
    public float displayImageDuration = 1f;
    public GameObject car;
    public CanvasGroup exitBackgroundImageCanvasGroup;
    bool m_IsPlayerAtExit;
    float m_Timer;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == car)
        {
            m_IsPlayerAtExit = true;
        }
    }
    void Update()
    {
        if (m_IsPlayerAtExit)
        {
            EndLevel();
        }
    }
    void EndLevel()
    {
        m_Timer += Time.deltaTime;
        exitBackgroundImageCanvasGroup.alpha = m_Timer / fadeDuration;
        if (m_Timer > fadeDuration + displayImageDuration)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
