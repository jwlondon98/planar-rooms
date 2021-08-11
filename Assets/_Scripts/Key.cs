using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : Grabbable
{ 
    #region Declarations

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

    public void TryUnlock(Lock lockObj)
    {
        if (lockObj.unlocked)
            return;

        bool unlock = lockObj.TryKey(this);
    }

    #endregion
}
