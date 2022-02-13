using System;
using System.Collections;
using System.Collections.Generic;
using Commands;
using UnityEngine;
using UnityEngine.InputSystem;
using ViewModel;
using UniRx;

namespace Components
{
    public class PlayerDisplay : MonoBehaviour
    {
        public EnviromentData enviromentData;
        public IPlayerMovement playerMovement;

        void Awake() 
        {
            playerMovement = GetComponent<IPlayerMovement>();   
        }

        void Start()
        {
            enviromentData.placementValid
                .Subscribe(OnPlacementValid)
                .AddTo(this);
        }

        private void OnPlacementValid(bool isValid)
        {
            this.gameObject.SetActive(isValid);
            if(isValid)
                playerMovement.RestartPosition(enviromentData.placementPose.Value);
        }
    }
}
