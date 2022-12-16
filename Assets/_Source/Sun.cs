using System.Collections;
using System.Collections.Generic;
using Interface;
using UnityEngine;
using DG.Tweening;

public class Sun : MonoBehaviour, IObserver
{
    private IObservable _observable;
    private float _speedRotation;
    private float _deltaTime;
    
    void Update()
    {
        ConcreteObserver();
        transform.RotateAround(Vector3.zero, Vector3.back, 1 / 4);
    }

    public void AddObservable(IObservable observable)
    {
        _observable = observable;
        
    }

    public void ConcreteObserver()
    {
        _deltaTime = _observable.ConcreteObservable();
    }
}
