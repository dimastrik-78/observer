using System;
using System.Collections.Generic;
using Interface;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private Sun sun;
        [SerializeField] private Sky sky;
        [SerializeField] private Star[] star;
        [SerializeField] private float timeStage;
        
        private Timer _check;
        
        void Start()
        {
            _check = new Timer(timeStage);
            _check.Register(sun);
            _check.Register(sky);
            
            for (int i = 0; i < star.Length; i++)
            {
                _check.Register(star[i]);
            }

            sun.Construct(timeStage);
            sky.Construct(timeStage);

            for (int i = 0; i < star.Length; i++)
            {
                star[i].Construct(timeStage);
            }
        }

        private void Update()
        {
            _check.Update();
            
        }
    }
}
