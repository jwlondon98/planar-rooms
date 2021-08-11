using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointManager : MonoBehaviour
{
    public bool useDebugCP = false;
    public int debugCP;
    
    public List<Checkpoint> checkpoints = new List<Checkpoint>();
    
    public GameObject cpLoadedObj;
    public GameObject cpSavedObj;
    
    public static CheckpointManager instance;
    
    private void Awake() {
        instance = this;    
    }
    
    void Start()
    {
        int cp = PlayerPrefs.GetInt("cp", 0);
        
        if (!useDebugCP)
            LoadCheckpoint(cp);
        else
            LoadCheckpoint(debugCP);
    }

    void Update()
    {
        
    }
    
    public int GetCPIndex(Checkpoint cp)
    {
        return checkpoints.IndexOf(cp);
    }
    
    public void SaveCheckpoint(int cpi)
    {
        PlayerPrefs.SetInt("cp", cpi);
        cpSavedObj.SetActive(true);
    }
    
    public void LoadCheckpoint()
    {
        int cpi = PlayerPrefs.GetInt("cp");
        PCPlayerControl.instance.LoadCheckpoint(checkpoints[cpi]);
        cpLoadedObj.SetActive(true);
    }
    
    public void LoadCheckpoint(int cp)
    {
        PCPlayerControl.instance.LoadCheckpoint(checkpoints[cp]);
        
        if (cp != 0)
            cpLoadedObj.SetActive(true);
    }
}
