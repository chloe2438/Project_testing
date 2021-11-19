using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time_ : MonoBehaviour
{
    //Clock Start Time
    public int Start_Hour = 0;
    public int Start_Minute = 0;
    public int Start_Second = 0;

    //Clock Hands
    public GameObject Hour_Hand;
    public GameObject Minute_Hand;
    public GameObject Second_Hand;

    public int Hour;
    public int Minute;
    public float Second;
    private float time_holder = 0.0f;
    void Start()
    {
        Hour = Start_Hour;
        Minute = Start_Minute;
        Second = Start_Second;
        TimeApply(Start_Hour,Start_Minute,Start_Second);
    }
    void Update()
    {
        time_holder += Time.deltaTime;
        if (time_holder >= 1){
            Second++;
            time_holder =0;
            TimeAddSec();

            if (Second >= 60)
            {
                Second = 0;
                Minute++;
                TimeAddMin();
                if (Minute >= 60)
                {
                    Minute = 0;
                    Hour++;
                }
            }
        }

    }
    public void TimeApply(int _Hour, int _Minute, int _Second)
    {
        Second_Hand.transform.Rotate(new Vector3(0,0,_Second*6));
        Minute_Hand.transform.Rotate(new Vector3(0,0,_Minute*6));
        Hour_Hand.transform.Rotate(new Vector3(0,0,_Hour*30f+_Minute*0.5f));
    }
    public void TimeAddSec()
    {
        Second_Hand.transform.Rotate(new Vector3(0,0,6));
    }
    public void TimeAddMin()
    {
        Minute_Hand.transform.Rotate(new Vector3(0,0,6));
        Hour_Hand.transform.Rotate(new Vector3(0,0,0.5f));
    }
    
}
