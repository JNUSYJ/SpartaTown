using System;
using UnityEngine;
using UnityEngine.UI;

public class TimeUI : MonoBehaviour
{
    private DateTime nowTime;
    private Text timeText;

    private void Start()
    {
        timeText = GetComponentInChildren<Text>();
    }

    private void Update()
    {
        nowTime = DateTime.Now;
        timeText.text = nowTime.ToString("HH:mm");
    }
}
