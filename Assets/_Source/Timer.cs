using System.Collections;
using System.Collections.Generic;
using Interface;
using UnityEngine;

public class Timer : IObservable
{
    private readonly List<IObserver> _observers;
    private readonly float _startTime;
    private int _stageDay;
    private float _time;
    
    public Timer(float timeStage)
    {
        _observers = new List<IObserver>();
        
        _startTime = timeStage;
        _time = timeStage;
    }
    
    public void Update()
    {
        Check();
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
            _observers[i].OnNotify(_stageDay);
        }
    }

    // public float ConcreteObservable() => _time;

    private void Check()
    {
        _time -= Time.deltaTime;
        Notify();
        if (_time <= 0)
        {
            _stageDay++;
            if (_stageDay >= 4)
                _stageDay = 0;
            
            _time = _startTime;
        }
    }
}
