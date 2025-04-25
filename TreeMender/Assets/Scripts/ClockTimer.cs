using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ClockTimer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI uiTimerText;
    [SerializeField] float timerMultiplier = 1;
    private float timerOutput;
    private float seconds;
    private float minutes;

    private void Update()
    {
        timerOutput += Time.deltaTime * timerMultiplier;
        minutes = Mathf.FloorToInt(timerOutput / 60);
        seconds = Mathf.FloorToInt(timerOutput % 60);
        uiTimerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if (minutes > 15)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        }
    }
}