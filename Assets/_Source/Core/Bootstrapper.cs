using System;
using System.Collections.Generic;
using Interface;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private Sun sun;
        // [SerializeField] private Sky sky;
        // [SerializeField] private Star star;
        [SerializeField] private float timeStage;
        
        private CheckTime _check;
        
        void Start()
        {
            _check = new CheckTime(timeStage);
            _check.Register(sun);
            // _check.Register(sky);
            // _check.Register(star);
            
            // sun.AddObservable(_check);
        }

        private void Update()
        {
            _check.Update();
            
        }
    }
}
