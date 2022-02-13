using System;
using System.Collections;
using System.Collections.Generic;
using Commands;
using UnityEngine;
using UnityEngine.InputSystem;
using ViewModel;

namespace Components
{
    public class PlayerSpawnerInput : MonoBehaviour
    {
        public GameData gameData;
        public EnviromentData enviromentData;
        public GameCmdFactory gameCmdFactory;

        public void Start()
        {
            ARInputManager.Instance.Controls.Player.Click.performed += ctx => OnClick(ctx);
        }

        private void OnClick(InputAction.CallbackContext ctx)
        {
            if(!enviromentData.placementValid.Value)
                return;

            gameCmdFactory.playerPlayCmd(gameData, enviromentData).Execute();
        }
    }
}
