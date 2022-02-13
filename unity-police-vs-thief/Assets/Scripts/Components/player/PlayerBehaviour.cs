using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;

namespace Components
{
    public class PlayerBehaviour : MonoBehaviour
    {
        public EnviromentData enviromentData;
        public GameData gameData;
        private float _speed = 1.2f;
        public IPlayerMovement playerMovement; 

        void Awake() 
        {
            playerMovement = GetComponent<IPlayerMovement>();    
        }

        void Start()
        {
            playerMovement.RestartPosition(enviromentData.placementPose.Value);
        }

        private void Update()
        {
            playerMovement.Move(enviromentData.placementPose.Value, _speed);
        }
    }
}
