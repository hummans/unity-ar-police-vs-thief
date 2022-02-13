using System;
using System.Collections;
using UnityEngine;
using ViewModel;

namespace Components
{
    public class ARPlacementTrackPose : MonoBehaviour
    {
        public IPlacementPose placementPoseController;
        public EnviromentData enviromentData;

        public void Awake()
        {
            placementPoseController = GetComponent<IPlacementPose>();
        }

        void Update()
        {
            if(!enviromentData.enviromentAviable)
                return;
                
            placementPoseController.UpdatePlacementPose();
        }
    }
}
