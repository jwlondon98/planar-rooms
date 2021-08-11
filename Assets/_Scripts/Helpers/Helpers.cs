#region Imports
 
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#endregion

#region Class

public static class Helpers
{
    #region Custom Methods

    /// <summary>
    /// Returns true if the first collider's bounds contain the second collider's bounds' closest
    /// point to this fisrt collider's transform.position
    ///
    /// In other words, returns true if a point on col2bounds is in col1bounds
    /// </summary>
    /// <param name="col1Bounds"></param>
    /// <param name="col2Bounds"></param>
    /// <param name="t">The transform of the first collider's gameObject</param>
    /// <returns></returns>
    public static bool IsInBounds(Bounds col1Bounds, Bounds col2Bounds, Transform t)
    {
        return col1Bounds.Contains(col2Bounds.ClosestPoint(t.position));
    }

    public static RaycastHit Raycast(Vector3 origin, Vector3 dir, float dist)
    {
        RaycastHit hit;
        Physics.Raycast(origin, dir, out hit, dist);
        return hit;
    }

    public static RaycastHit Raycast(Vector3 origin, Vector3 dir, float dist, LayerMask layerMask)
    {
        RaycastHit hit;
        Physics.Raycast(origin, dir, out hit, dist, layerMask);
        return hit;
    }

    public static void NullCheck(UnityEngine.Object obj)
    {
        if (obj == null)
        {
            Debug.Log("Object not found");
            return;
        }

        string name = obj.GetType().ToString();
        Debug.Log(name + " found");
    }

    #endregion
}

#endregion
