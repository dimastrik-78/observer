using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Interface;
using UnityEngine;
using UnityEngine.UI;

public class Sky : MonoBehaviour, IObserver
{
    [SerializeField] private Color[] colors;

    private Image _image;
    private float _changeTime;

    public void Construct(float timeStage)
    {
        _changeTime = timeStage;
    }
    
    private void Start()
    {
        _image = GetComponent<Image>();
    }

    public void OnNotify(int stageDay)
    {
        _image.DOColor(colors[stageDay], _changeTime);
    }
}
