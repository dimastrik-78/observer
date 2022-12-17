using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Interface;
using UnityEngine;
using UnityEngine.UI;

public class Star : MonoBehaviour, IObserver
{
    private Image _color;
    private float _changeTime;
    
    private void Start()
    {
        _color = GetComponent<Image>();
    }
    
    public void Construct(float timeStage)
    {
        _changeTime = timeStage;
    }

    public void OnNotify(int stageDay)
    {
        if (stageDay == 2)
        {
            _color.DOColor(Color.white, _changeTime);
        }
        else if (stageDay == 3)
        {
            _color.DOColor(Color.clear, _changeTime);
        }
    }
}
