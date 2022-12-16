using System.Collections;
using System.Collections.Generic;
using Interface;
using UnityEngine;
using DG.Tweening;

public class Sun : MonoBehaviour, IObserver
{
    private IObservable _observable;
    private Transform _transform;
    private float _speedRotation;
    private float _deltaTime;

    public void AddObservable(IObservable observable)
    {
        _observable = observable;
        
    }

    public void OnNotify()
    {
        ConcreteObserver();
        transform.RotateAround(Vector3.zero, Vector3.back, 0.25f);
    }

    public void ConcreteObserver()
    {
        // _deltaTime = _observable.ConcreteObservable();
    }
}
