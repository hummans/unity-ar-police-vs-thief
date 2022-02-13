using UnityEngine;

namespace Components
{
    public class PlayerMovement : MonoBehaviour, IPlayerMovement
    {
        public void Move(Pose _placementPose, float _speed)
        {
            var trackingPosition = _placementPose.position;
            if (Vector3.Distance(trackingPosition, transform.position) < 0.1)
            {
                return;
            }

            _speed = NormalizeSpeed(_speed, trackingPosition);

            var lookRotation = Quaternion.LookRotation(trackingPosition - transform.position);
            transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, Time.deltaTime * 10f);
            transform.position = Vector3.MoveTowards(transform.position, trackingPosition, _speed * Time.deltaTime);
        }

        private float NormalizeSpeed(float _speed, Vector3 trackingPosition)
        {
            if (Vector3.Distance(trackingPosition, transform.position) < 0.4f)
            {
                _speed = _speed / 2;
            }
            return _speed;
        }

        public void RestartPosition(Pose _placementPose)
        {
            transform.position = _placementPose.position;
            transform.rotation = _placementPose.rotation;
        }
    }
}
