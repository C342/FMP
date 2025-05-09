using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ClockTimer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI uiTimerText;
    [SerializeField] TextMeshProUGUI uiDateText;
    [SerializeField] float timerMultiplier = 2.5f;

    private float timerOutput;
    private float seconds;
    private float minutes;
    private int currentDayIndex = 0;

    private string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
    private float dayInterval = 5f;
    private float nextDayTime = 5f;

    private void Update()
    {
        timerOutput += Time.deltaTime * timerMultiplier;
        minutes = Mathf.FloorToInt(timerOutput / 60);
        seconds = Mathf.FloorToInt(timerOutput % 60);
        uiTimerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if (minutes >= nextDayTime)
        {
            AdvanceDay();
        }

        uiDateText.text = days[currentDayIndex % days.Length];
    }

    private void AdvanceDay()
    {
        currentDayIndex++;
        nextDayTime += dayInterval;
    }
}