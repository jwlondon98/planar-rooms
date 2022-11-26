using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class HandTracker : MonoBehaviour
{
    public Transform handTarget;
    public Vector3 rotOffset;
    
    void Update()
    {
        handTarget.transform.position = transform.position;
        handTarget.transform.rotation = transform.rotation * Quaternion.Euler(rotOffset);
    }
}
