using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tides : MonoBehaviour
{
    //public float worldTimer;        // keeps track of real time for the purpose of in-game time
    //public int intervalLength;      // number of IRL seconds before an interval of in-game time occurs
    //public int gameTimeInterval;    // number of in-game minutes that pass each interval, MUST BE >=1 AND <=60
    //                                // NOTE: to determine number of real-time minutes pass in an in-game 24 hours, use equation ((60/timeInterval)*24*timeSpeed)/60

    //int currentHour;                // the current hour in game
    //int currentMinute;              // the current minute in game

    //public float currentTide;       // the current tide in game (0 = low, 1 = high)

    //bool tideRising;                // is the tide rising currently? (if it isn't, it is falling)
    //public float tideSpeed;         // how many hours until a tide change

    //public Slider currentTideSlider;    // Unity UI slider to show the current tide
    //public TMPro.TMP_Text timeText;     // Unity UI text to show the current time

    void Start()
    {
        //worldTimer = 0;
        //currentHour = 8;
        //currentMinute = 0;
        //currentTide = 0;
        //tideRising = true;

        //if (currentMinute < 10)
        //{
        //    timeText.text = "Time: " + currentHour + ":0" + currentMinute;
        //}
        //else
        //{
        //    timeText.text = "Time: " + currentHour + ":" + currentMinute;
        //}
    }

    void Update()
    {
        //worldTimer += Time.deltaTime;
        //if (tideRising)
        //{                                                                                               // the current tide is a fraction equaling Time.deltaTime divided by
        //    currentTide += Time.deltaTime / (((60 / gameTimeInterval) * tideSpeed) * intervalLength);   // the number of IRL seconds required to reach the number of in-game
        //}                                                                                               // time intervals needed to reach the tide speed
        //else
        //{
        //    currentTide -= Time.deltaTime / (((60 / gameTimeInterval) * tideSpeed) * intervalLength);
        //}

        //currentTideSlider.value = currentTide;

        //if (worldTimer >= intervalLength)
        //{
        //    currentMinute += gameTimeInterval;

        //    while(currentMinute >= 60)
        //    {
        //        currentHour++;
        //        currentMinute -= 60;
        //    }

        //    worldTimer = 0;

        //    if(currentMinute < 10)      // TODO maybe adjust to not include 'Time:'
        //    {                           // TODO adjust from 24hr clock/have the option for either
        //        timeText.text = "Time: " + currentHour + ":0" + currentMinute;
        //    }
        //    else
        //    {
        //        timeText.text = "Time: " + currentHour + ":" + currentMinute;
        //    }

        //if(currentTide >= 1)
        //{
        //    tideRising = false;

        //    // TODO* debug code
        //    //if (currentMinute < 10)
        //    //{
        //    //    Debug.Log("Tide changed at " + currentHour + ":0" + currentMinute);
        //    //}
        //    //else
        //    //{
        //    //    Debug.Log("Tide changed at " + currentHour + ":" + currentMinute);
        //    //}
        //}
        //if (currentTide <= 0)
        //{
        //    tideRising = true;

        //    // TODO* debug code
        //    //if (currentMinute < 10)
        //    //{
        //    //    Debug.Log("Tide changed at " + currentHour + ":0" + currentMinute);
        //    //}
        //    //else
        //    //{
        //    //    Debug.Log("Tide changed at " + currentHour + ":" + currentMinute);
        //    //}
        //}
        //}
    }
}