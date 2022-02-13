
using UnityEngine;
using ViewModel;

namespace Commands
{
    [CreateAssetMenu(fileName = "GameCmdFactory", menuName = "Data/GameCmdFactory", order = 0)]
    public class GameCmdFactory : ScriptableObject 
    {
        public PlayerPlayCmd playerPlayCmd(GameData gameData, EnviromentData enviromentData)
        {
            return new PlayerPlayCmd(gameData, enviromentData);
        }
    }
}