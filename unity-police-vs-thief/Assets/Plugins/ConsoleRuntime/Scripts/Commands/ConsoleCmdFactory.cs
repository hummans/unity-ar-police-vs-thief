using UnityEngine;
using ViewModel;

namespace Commands
{    
    [CreateAssetMenu(fileName = "ConsoleCmdFactory", menuName = "Console/Command Factory", order = 0)]
    public class ConsoleCmdFactory : ScriptableObject 
    {
        public ConsoleApplicationCmd consoleApplication(ConsoleViewModel consoleData, LogType type, string logString)
        {
            return new ConsoleApplicationCmd(consoleData, type, logString);
        }    
        public ConsoleApplicationPersistanceSaveCmd consoleSave(ConsoleViewModel consoleData)
        {
            return new ConsoleApplicationPersistanceSaveCmd(consoleData);
        }    
    }
}
