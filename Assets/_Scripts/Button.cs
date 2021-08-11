using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

public class Button : MonoBehaviour
{
    public bool pressed = false;
    
    [Serializable]
    public class ButtonClickedEvent : UnityEvent {}
    
    // Event delegates triggered on click.
    [FormerlySerializedAs("onClick")]
    [SerializeField]
    private ButtonClickedEvent m_OnClick = new ButtonClickedEvent();
    
    public ButtonClickedEvent onClick
    {
        get { return m_OnClick; }
        set { m_OnClick = value; }
    }
    
    private Animator animator;
    
    private void Awake() 
    {
        animator = GetComponent<Animator>();    
    }
    
    public void OnPress()
    {
        pressed = true;
        animator.SetBool("OnPress", true);
    }
}
