using UnityEngine;

namespace Phyzk
{
    public class LimbTracker : MonoBehaviour
    {
        public Transform limbTarget;
        public Vector3 limbOffset;
        public Vector3 rotOffset;
        public bool localToWorldSpacePos;
        public Vector2 xClamp;
        public Vector2 yClamp;
        public Vector2 zClamp;
        
        void Update()
        {
            // var posOffset = localToWorldSpacePos ? transform.TransformPoint(limbOffset) : limbOffset;
            // limbTarget.transform.position = transform.position + posOffset;
            limbTarget.transform.rotation = transform.rotation * Quaternion.Euler(rotOffset);
        }
    }
}