using Components;
using UnityEngine;
using ViewModel;

namespace Commands
{
    public class PlayerPlayCmd : ICommand
    {
        private EnviromentData enviromentData;
        private GameData gameData;

        public PlayerPlayCmd(GameData gameData, EnviromentData enviromentData)
        {
            this.gameData = gameData;
            this.enviromentData = enviromentData;
        }

        public void Execute()
        {
            if(gameData.isPlayerInGame)//|| !enviromentData.enviromentAviable)
                return;

            enviromentData.OnPlay.OnNext(1500);
            GameObject placementIndicator = GameObject.Find("PlacementIndicator");

            GameObject player = GameObject.Instantiate(gameData.playerPrefab, enviromentData.placementPose.Value.position, enviromentData.placementPose.Value.rotation);
            gameData.isPlayerInGame = true;
        }
    }
}