using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GrObjType {
    Key, Lock
};
 
public class Grabbable : MonoBehaviour
{
    #region Declarations

    public GrObjType grObjType;

    public bool canBeGrabbed = true;

    #endregion

    #region Unity Methods

    private void Awake()
    {

    }

    void Start()
    {

    }

    void Update()
    {

    }

    #endregion

    #region Custom Methods

    #endregion
}
