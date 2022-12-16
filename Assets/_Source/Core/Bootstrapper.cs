using System;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private Sun sun;
        [SerializeField] private float timeStage;
        
        private CheckTime _check;
        
        void Start()
        {
            _check = new CheckTime(timeStage);
            
            sun.AddObservable(_check);
        }

        private void Update()
        {
            _check.Update();
        }
    }
}
