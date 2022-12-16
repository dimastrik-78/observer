using System.Collections;
using System.Collections.Generic;
using Interface;
using UnityEngine;

public class CheckTime : IObservable
{
    private List<IObserver> _observers;
    private readonly float _startTime;
    private float _time;
    
    public CheckTime(float timeStage)
    {
        _observers = new List<IObserver>();
        
        _startTime = timeStage;
        _time = timeStage;
    }
    
    public void Update()
    {
        Timer();
    }

    public void Register(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Remove(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        for (int i = 0; i < _observers.Count; i++)
        {
            _observers[i].OnNotify();
        }
    }

    public float ConcreteObservable() => _time;

    private void Timer()
    {
        _time -= Time.deltaTime;
        Notify();
        if (_time <= 0)
        {
            _time = _startTime;
        }
    }
}
