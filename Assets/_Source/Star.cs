using System.Collections;
using System.Collections.Generic;
using Interface;
using UnityEngine;

public class Star : MonoBehaviour, IObserver
{
    private IObservable _observable;

    public void AddObservable(IObservable observable)
    {
        _observable = observable;
        
    }

    public void OnNotify()
    {
        ConcreteObserver();
    }

    public void ConcreteObserver()
    {
        
    }
}
