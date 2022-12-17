using System.Collections;
using System.Collections.Generic;
using Interface;
using UnityEngine;
using DG.Tweening;

public class Sun : MonoBehaviour, IObserver
{
    [SerializeField] private Transform[] positions;
    private float _speedMove;
    private float _deltaTime;

    public void Construct(float timeStage)
    {
        _speedMove = timeStage;
    }

    public void OnNotify(int stageDay)
    {
        transform.DOMove(positions[stageDay].position, _speedMove);
    }
}
