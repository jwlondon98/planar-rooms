using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class DISCROTATOR : MonoBehaviour
{
    public bool rotate = true;

    public float speed;

    private void Update()
    {
        if (rotate)
        {
            transform.Rotate(new Vector3(0, 0, speed));
        }
    }
}
