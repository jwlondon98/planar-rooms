using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public bool unfrozen = false;
    private Rigidbody rb;
    
    private void Awake() {
        rb = GetComponent<Rigidbody>();
    }
    
    public void Unfreeze()
    {
        rb.useGravity = true;
        unfrozen = true;
    }
}
