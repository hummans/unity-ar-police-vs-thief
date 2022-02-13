using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using ViewModel;

namespace Components
{
    public class PlacementPoseController : MonoBehaviour, IPlacementPose 
    {
        public EnviromentData enviromentData;
        public ARRaycastManager raycastManager;
        public Camera mainCamera;
        private bool placementPoseValid = false;
        private Pose placementPose = new Pose();

        public void UpdatePlacementPose()
        {
            var screenCenter = mainCamera.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));
            var hits = new List<ARRaycastHit>();
            raycastManager.Raycast(screenCenter, hits, TrackableType.PlaneWithinPolygon);
            placementPoseValid = hits.Count > 0;
            if(placementPoseValid)
            {
                placementPose = hits[0].pose;
            }
            enviromentData.placementPose.Value = placementPose;
            enviromentData.placementValid.Value = placementPoseValid;
        }
    }
}
