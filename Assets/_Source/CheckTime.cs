using System.Collections;
using System.Collections.Generic;
using Interface;
using UnityEngine;

public class CheckTime : IObservable
{
    private readonly float _startTime;
    private float _time;
    
    public CheckTime(float timeStage)
    {
        _startTime = timeStage;
        _time = timeStage;
    }
    
    public void Update()
    {
        Timer();
    }

    public float ConcreteObservable() => _time;

    private void Timer()
    {
        _time -= Time.deltaTime;
        if (_time <= 0)
        {
            _time = _startTime;
        }
    }
}
