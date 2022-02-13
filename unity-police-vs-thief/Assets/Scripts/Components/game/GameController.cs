
using UnityEngine;
using ViewModel;

namespace Components
{    
    public class GameController : MonoBehaviour 
    {
        public GameData gameData;
        public EnviromentData enviromentData;

        public void Start() 
        {
            enviromentData.enviromentAviable = true;
            gameData.isPlayerInGame = false;
        }    
    }
}