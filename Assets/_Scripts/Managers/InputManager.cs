using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Phyzk
{
    public class InputManager : MonoBehaviour
    {
        #region Declarations
        
        #region Events
        
        public event Action<Vector2> onLeftJoystick; 
        public event Action<Vector2> onRightJoystick; 
        public event Action<float> onGripLeft; 
        public event Action<float> onGripRight; 
        public event Action<float> onTriggerLeft; 
        public event Action<float> onTriggerRight; 
        public event Action<bool> onPrimaryLeft; 
        public event Action<bool> onSecondaryLeft; 
        public event Action<bool> onPrimaryRight; 
        public event Action<bool> onSecondaryRight; 
        
        #endregion
        
        #region Input Values

        [SerializeField] private Vector2 leftJoystickInput;
        [SerializeField] private Vector2 rightJoystickInput;
        [SerializeField] private float leftGripInput;
        [SerializeField] private float rightGripInput;
        [SerializeField] private float leftTriggerInput;
        [SerializeField] private float rightTriggerInput;
        [SerializeField] private Quaternion deviceRotation;
        [SerializeField] private Vector3 devicePosition;
        
        #endregion
        
        public static InputManager instance;
        
        #endregion

        private void Awake()
        {
            instance = this;
        }

        public void Left_Joystick(InputAction.CallbackContext context)
        {
            leftJoystickInput = context.ReadValue<Vector2>();
            onLeftJoystick.Invoke(leftJoystickInput);
        }
        
        public void Right_Joystick(InputAction.CallbackContext context)
        {
            rightJoystickInput = context.ReadValue<Vector2>();
            onRightJoystick.Invoke(rightJoystickInput);
        }
        
        public void Grip_Left(InputAction.CallbackContext context)
        {
            leftGripInput = context.ReadValue<float>();
            onGripLeft.Invoke(leftGripInput);
        }
        
        public void Grip_Right(InputAction.CallbackContext context)
        {
            rightGripInput = context.ReadValue<float>();
            onGripRight.Invoke(rightGripInput);
        }
        
        public void Trigger_Left(InputAction.CallbackContext context)
        {
            leftTriggerInput = context.ReadValue<float>();
            onTriggerLeft.Invoke(leftTriggerInput);
        }
        
        public void Trigger_Right(InputAction.CallbackContext context)
        {
            rightTriggerInput = context.ReadValue<float>();
            onTriggerRight.Invoke(rightTriggerInput);
        }
        
        public void Primary_Left(InputAction.CallbackContext context)
        {
            var val = context.ReadValueAsButton();
            onPrimaryLeft.Invoke(val);
        }
        
        public void Secondary_Left(InputAction.CallbackContext context)
        {
            var val = context.ReadValueAsButton();
            onSecondaryLeft.Invoke(val);
        }
        
        public void Primary_Right(InputAction.CallbackContext context)
        {
            var val = context.ReadValueAsButton();
            onPrimaryRight.Invoke(val);
        }
        
        public void Secondary_Right(InputAction.CallbackContext context)
        {
            var val = context.ReadValueAsButton();
            onSecondaryRight.Invoke(val);
        }
    }
}