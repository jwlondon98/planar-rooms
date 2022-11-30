using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntigravityChamber : MonoBehaviour
{
    public bool resetGravityOnEnter;
    
    public float gravity;
    public float maxVelocity;
    public bool playerInside;
    
    public bool gravitySwitched = false;
    
    public List<Rigidbody> rbList = new List<Rigidbody>();
    
    private FPSController player;
    
    private void Start() {
        player = FPSController.instance;    
    }
    
    private void OnTriggerEnter(Collider col) 
    {   
        if (resetGravityOnEnter && col.CompareTag("Player"))
            return;
        
        Rigidbody rb = col.gameObject.GetComponent<Rigidbody>();
        if (rb != null && !rbList.Contains(rb))
            rbList.Add(rb);
            
        if (col.CompareTag("Player"))
            playerInside = true;
    }
    
    private void OnTriggerStay(Collider col) 
    {
        if (resetGravityOnEnter && col.CompareTag("Player"))
        {
            // player.gravity = player.initGravity;  
            // print(name + " reset gravity");          
        }    
    }
    
    private void OnTriggerExit(Collider col) 
    {
        Rigidbody rb = col.gameObject.GetComponent<Rigidbody>();
        rbList.Remove(rb);
        
        if (col.CompareTag("Player"))
        {
            playerInside = false;
        }
    }
    
    private void FixedUpdate() 
    {
        ApplyGravity();
    }
    
    public void ApplyGravity()
    {
        // if (playerInside && gravity != 0)
        //     player.gravity = -gravity;
        
        for (int i = 0; i < rbList.Count; i++)
        {
            Rigidbody rb = rbList[i];
            rb.AddForce(Vector3.up * gravity);  
        }    
    }
    
    public void FlipGravity()
    {
        gravity *= -1;
    }
    
    public void MakeAntiGravity()
    {
        if (gravity < 0 && !gravitySwitched)
        {
            gravity *= -1;
            gravitySwitched = true;
        }
    }
    
    public void MakeGravity()
    {
        if (gravity > 0 && !gravitySwitched)
        {
            gravity *= -1;
            gravitySwitched = true;            
        }
    }
}
