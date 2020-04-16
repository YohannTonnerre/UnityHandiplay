using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
 
public class timer : MonoBehaviour
{
    public float start = 600;
 
    private Text time;
 
    private void Start()
    {
        time = GetComponent<Text>();
    }
 
    private void Update()
    {
        start = Mathf.Max(0, start - Time.deltaTime);
        TimeSpan timeSpan = TimeSpan.FromSeconds(start);
        time.text = timeSpan.Minutes.ToString("00") + ":" + timeSpan.Seconds.ToString("00") + "	";
    }
}
