using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

public class BallRoom : MonoBehaviour
{
    public Ball ball1;
    public Ball ball2;
    
     [Serializable]
    public class ButtonClickedEvent : UnityEvent {}
    
    // Event delegates triggered on click.
    [FormerlySerializedAs("onClick")]
    [SerializeField]
    private ButtonClickedEvent m_OnClick = new ButtonClickedEvent();
    
    public static BallRoom instance;
    
    public ButtonClickedEvent onClick
    {
        get { return m_OnClick; }
        set { m_OnClick = value; }
    }
    
    private void Awake() {
        instance = this;    
    }
    
    public void CheckUnfrozen()
    {
        if (ball1.unfrozen && ball2.unfrozen)
            onClick.Invoke();
    }
}
