using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Util : MonoBehaviour
{
    [SerializeField] private Material mat;
    [SerializeField] private Mesh mesh;
    
    [ContextMenu("Change Mats")]
    void ChangeMats()
    {
        var rends = FindObjectsOfType<MeshRenderer>();
        foreach (var rend in rends)
        {
                rend.material = mat;
                Debug.Log("changed mesh");
        }
    }
}
