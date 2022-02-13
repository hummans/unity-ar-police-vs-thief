using UnityEngine;

namespace ViewModel
{   
    [CreateAssetMenu(fileName = "GameData", menuName = "ViewModel/GameData", order = 0)]
    public class GameData : ScriptableObject 
    {
        public GameObject playerPrefab;
        public float playerSpeed;
        public bool isPlayerInGame;
    }
}