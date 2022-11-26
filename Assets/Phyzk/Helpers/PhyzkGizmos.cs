using System;
using UnityEngine;

namespace Phyzk
{
    public class PhyzkGizmos : MonoBehaviour
    {
        [SerializeField] private bool drawDirectionalGizmos = true;
        [SerializeField] private Vector3 directionalLengths = new Vector3(5, 5, 5);
        
        private void OnDrawGizmos()
        {
            if (drawDirectionalGizmos)
            {
                var pos = transform.position;
                Gizmos.color = Color.red;
                Gizmos.DrawLine(pos, pos + transform.right * directionalLengths.x);
                Gizmos.color = Color.green;
                Gizmos.DrawLine(pos, pos + transform.up * directionalLengths.y);
                Gizmos.color = Color.blue;
                Gizmos.DrawLine(pos, pos + transform.forward * directionalLengths.z);
            }
        }
    }
}