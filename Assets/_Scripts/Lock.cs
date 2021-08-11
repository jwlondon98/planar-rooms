using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : Grabbable
{ 
    #region Declarations

    public bool unlocked;

    public Key requiredKey;

    public Vector3 keyPlacePos;

    public List<AnimObj> animObjs = new List<AnimObj>();

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

    public bool TryKey(Key key)
    {
        if (key.Equals(requiredKey))
        {
            key.gameObject.SetActive(true);
            key.GetComponent<Rigidbody>().isKinematic = true;
            key.transform.position = transform.position;
            key.transform.parent = transform;

            tag = "Untagged";
            unlocked = true;

            for (int i = 0; i < animObjs.Count; i++)
            {
                AnimObj animObj = animObjs[i];
                if (animObj)
                    animObj.anim.Play(animObj.animName, -1, 0);
            }
            return true;
        }

        return false;
    }

    #endregion
}
