using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimeManager : MonoBehaviour
{
    public GameObject hourIndex;
    public GameObject minuteIndex;
    public GameObject secondIndex;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int seconds = System.DateTime.Now.Second;
        int minutes = System.DateTime.Now.Minute;
        int hours = System.DateTime.Now.Hour;
        float hourAngle = (hours * 30) + (minutes * 0.5f) + (seconds * 0.5f / 60);
        float minuteAngle = (minutes * 6) + (seconds * 0.1f);
        float secondAngle = seconds * 6;

        hourIndex.transform.localRotation = Quaternion.Euler(90 + hourAngle, 0, -90);
        minuteIndex.transform.localRotation = Quaternion.Euler(90 + minuteAngle, 0, -90);
        secondIndex.transform.localRotation = Quaternion.Euler(90 + secondAngle, 0, -90);
    }
}
