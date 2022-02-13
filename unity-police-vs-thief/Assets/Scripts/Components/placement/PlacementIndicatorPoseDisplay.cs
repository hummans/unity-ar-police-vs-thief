using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using ViewModel;

namespace Components
{    
    public class PlacementIndicatorPoseDisplay : MonoBehaviour
    {
        public EnviromentData enviromentData;
        public Transform _transform;

        public void Start()
        {
            enviromentData.placementPose.Value = new Pose();
            enviromentData.placementPose
                .Subscribe(OnPlacementPoseChange)
                .AddTo(this);
        }
        private void OnPlacementPoseChange(Pose value)
        {
            if(!enviromentData.placementValid.Value)
                return;
            
            _transform.position = value.position;
            _transform.rotation = value.rotation;
        }
    }
}
