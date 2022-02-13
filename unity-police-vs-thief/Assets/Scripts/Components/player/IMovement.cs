using UnityEngine;

namespace Components
{
    public interface IPlayerMovement
    {
        void Move(Pose _placementPose, float _speed);
        void RestartPosition(Pose _placementPose);
    }
}
