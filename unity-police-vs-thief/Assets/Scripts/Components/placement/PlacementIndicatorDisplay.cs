using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using ViewModel;

namespace Components
{    
    public class PlacementIndicatorDisplay : MonoBehaviour
    {
        public EnviromentData enviromentData;
        public Renderer _renderer;

        public void Start()
        {
            enviromentData.placementValid
                .Subscribe(OnPlacementValid)
                .AddTo(this);
        }
        private void OnPlacementValid(bool isValid)
        {
            _renderer.enabled = isValid;
        }
    }
}
