using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FPSCamera : MonoBehaviour
{
    public float mouseSensitivity = 2f;
    private float cameraVerticalRotation = 0f;
    [SerializeField] private Transform camTransform;

    [Range(-90f, 0)] [SerializeField] private float vertRotMin;
    [Range(0, 90f)] [SerializeField] private float vertRotMax;
    public bool lockedCursor;

    public static FPSCamera instance;
    
    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        lockedCursor = true;
    }

    void Update()
    {
        Keyboard keyboard = Keyboard.current;
        if (keyboard.escapeKey.wasPressedThisFrame)
            lockedCursor = !lockedCursor;
        
        if (!lockedCursor)
            return;
        
        Mouse mouse = Mouse.current;
        var mouseX = mouse.delta.x.ReadValue() * mouseSensitivity;
        var mouseY = mouse.delta.y.ReadValue() * mouseSensitivity;

        cameraVerticalRotation -= mouseY;
        cameraVerticalRotation = Mathf.Clamp(cameraVerticalRotation, vertRotMin, vertRotMax);
        camTransform.localEulerAngles = Vector3.right * cameraVerticalRotation;
        
        transform.Rotate(Vector3.up * mouseX);
    }
}