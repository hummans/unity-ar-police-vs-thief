using UnityEngine;
using UniRx;

namespace ViewModel
{    
    [CreateAssetMenu(fileName = "EnviromentData", menuName = "ViewModel/EnviromentData", order = 0)]
    public class EnviromentData : ScriptableObject 
    {
        public bool enviromentAviable;
        public BoolReactiveProperty placementValid = new BoolReactiveProperty(false);
        public ReactiveProperty<Pose> placementPose = new ReactiveProperty<Pose>();
        public ISubject<float> OnPlay = new Subject<float>();
    }
}
