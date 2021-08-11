using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public bool reached = false;
    public int checkpointIndex = -1;
    
    private CheckpointManager checkpointManager;
    
    private void Awake() {
            
    }
    
    private void Start() {
        checkpointManager = CheckpointManager.instance;
        checkpointIndex = checkpointManager.GetCPIndex(this);
    }
    
    private void OnTriggerEnter(Collider col) 
    {
        if (reached)
            return;
        
        if (col.CompareTag("Player"))
        {
            reached = true;
            checkpointManager.SaveCheckpoint(checkpointIndex);
        }
    }
    
    public void DisableGameObject()
    {
        gameObject.SetActive(false);        
    }
}
