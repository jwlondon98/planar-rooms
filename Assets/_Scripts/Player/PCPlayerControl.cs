using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PCPlayerControl : MonoBehaviour
{ 
    #region Declarations

    public bool haxMode = true;

    public float grabbableDetectDistance;

    public bool holdingGrabbable = false;
    public Grabbable lastGrabbedObj;

    public Image reticle;
    public Sprite ret, retHit;

    private Camera cam;

    public static PCPlayerControl instance;

    #endregion

    #region Unity Methods

    private void Awake()
    {
        instance = this;
        cam = Camera.main;
    }

    void Start()
    {

    }

    void Update()
    {
        Raycast();
    }

    #endregion

    #region Custom Methods

    private void Raycast()
    {
        RaycastHit hit = Helpers.Raycast(cam.transform.position, cam.transform.forward, grabbableDetectDistance);
        
        if (hit.collider)
        {
            if (hit.collider.CompareTag("Grabbable"))
                DetectGrabbables(hit);
            else if (hit.collider.CompareTag("Button"))
                ActivateButton(hit);
            else
                reticle.sprite = ret;
        }
    }

    private void DetectGrabbables(RaycastHit hit)
    {
        reticle.sprite = retHit;

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Grabbable grabbable = hit.collider.GetComponent<Grabbable>();
            Lock lockObj = grabbable.GetComponent<Lock>();
            lockObj.TryKey(lockObj.requiredKey);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Grabbable grabbable = hit.collider.GetComponent<Grabbable>();

            // conditions
            if (lastGrabbedObj)
            {
                if (lastGrabbedObj.Equals(grabbable))
                    return;

                // check if trying to place a key in a lock
                if (lastGrabbedObj.grObjType == GrObjType.Key &&
                    grabbable.grObjType == GrObjType.Lock)
                {
                    lastGrabbedObj.GetComponent<Key>().TryUnlock(grabbable.GetComponent<Lock>());
                    return;
                }
            }

            if (!grabbable.canBeGrabbed)
                return;

            lastGrabbedObj = grabbable;
            lastGrabbedObj.gameObject.SetActive(false);
        }
    }
    
    private void ActivateButton(RaycastHit hit)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Button button = hit.collider.gameObject.GetComponent<Button>();
            
            if (button && !button.pressed)
            {
                button.pressed = true;
                button.onClick.Invoke();
            }
        }
    }
    
    public void LoadCheckpoint(Checkpoint cp)
    {
        cp.reached = true;
        transform.position = cp.transform.position;
        transform.rotation = cp.transform.rotation;
    }

    #endregion
}
