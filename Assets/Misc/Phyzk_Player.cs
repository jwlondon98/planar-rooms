// GENERATED AUTOMATICALLY FROM 'Assets/Misc/Phyzk_Player.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Phyzk_Player : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Phyzk_Player()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Phyzk_Player"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""aed2a129-9467-4c5b-a6ec-d8d0038220c7"",
            ""actions"": [
                {
                    ""name"": ""Left_Joystick"",
                    ""type"": ""Value"",
                    ""id"": ""b22f71de-7918-4c7c-9bfd-bc2f250c1e90"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right_Joystick"",
                    ""type"": ""Value"",
                    ""id"": ""956e1e45-7d05-4342-b2e6-1266a459dc81"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Grip_Left"",
                    ""type"": ""Value"",
                    ""id"": ""a23a6213-0539-4cc7-8c8e-a8d5efb848e7"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Grip_Right"",
                    ""type"": ""Value"",
                    ""id"": ""74603856-b55e-442d-b60b-b133d8b80a96"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Trigger_Left"",
                    ""type"": ""Value"",
                    ""id"": ""2218c878-7599-4ccb-b676-a762d3baf4f3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Trigger_Right"",
                    ""type"": ""Value"",
                    ""id"": ""5a51df44-e9fa-4a71-a900-d9bef2a8e67d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Primary_Right"",
                    ""type"": ""Value"",
                    ""id"": ""3d5b2692-6370-4538-ac5f-cd52299830f6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Secondary_Right"",
                    ""type"": ""Value"",
                    ""id"": ""0499eb10-41fe-4603-8340-263c5ba720b7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Primary_Left"",
                    ""type"": ""Value"",
                    ""id"": ""f40a88a4-3b49-41e2-b69b-8889d8243530"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Secondary_Left"",
                    ""type"": ""Value"",
                    ""id"": ""cef8e456-8b7e-4d73-b7e7-68b07a3dd7ec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d4570494-5353-45db-82f1-0f7f7362d47e"",
                    ""path"": ""<XRController>{LeftHand}/joystick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Left_Joystick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""86314b7f-4529-46b9-89f2-c7f4cf9c0593"",
                    ""path"": ""<XRController>{RightHand}/joystick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Right_Joystick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b507be4-fac5-47b5-9eec-083eacb67ae2"",
                    ""path"": ""<XRController>{LeftHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Grip_Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bd6d5bdb-7996-4d2f-96b4-f414dd870155"",
                    ""path"": ""<XRController>{RightHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Grip_Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""87d1fa4c-02d5-4624-b10d-f87b4362b7b8"",
                    ""path"": ""<XRController>{LeftHand}/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Trigger_Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c020a1d6-7886-45e9-8d3c-bb834206af57"",
                    ""path"": ""<XRController>{RightHand}/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Trigger_Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cb8cb0b3-d665-4d9e-a143-ae5e00432a36"",
                    ""path"": ""<XRController>{RightHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Primary_Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a59364c5-ac1d-4534-91e1-5ddad2071649"",
                    ""path"": ""<XRController>{LeftHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Primary_Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""43f50e17-3366-4ba8-8fe3-43cf73671cb6"",
                    ""path"": ""<XRController>{LeftHand}/secondaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Secondary_Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1cd77c5b-c866-4e95-94ee-1f42c9b4a22e"",
                    ""path"": ""<XRController>{RightHand}/secondaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Secondary_Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Left_Joystick = m_Player.FindAction("Left_Joystick", throwIfNotFound: true);
        m_Player_Right_Joystick = m_Player.FindAction("Right_Joystick", throwIfNotFound: true);
        m_Player_Grip_Left = m_Player.FindAction("Grip_Left", throwIfNotFound: true);
        m_Player_Grip_Right = m_Player.FindAction("Grip_Right", throwIfNotFound: true);
        m_Player_Trigger_Left = m_Player.FindAction("Trigger_Left", throwIfNotFound: true);
        m_Player_Trigger_Right = m_Player.FindAction("Trigger_Right", throwIfNotFound: true);
        m_Player_Primary_Right = m_Player.FindAction("Primary_Right", throwIfNotFound: true);
        m_Player_Secondary_Right = m_Player.FindAction("Secondary_Right", throwIfNotFound: true);
        m_Player_Primary_Left = m_Player.FindAction("Primary_Left", throwIfNotFound: true);
        m_Player_Secondary_Left = m_Player.FindAction("Secondary_Left", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Left_Joystick;
    private readonly InputAction m_Player_Right_Joystick;
    private readonly InputAction m_Player_Grip_Left;
    private readonly InputAction m_Player_Grip_Right;
    private readonly InputAction m_Player_Trigger_Left;
    private readonly InputAction m_Player_Trigger_Right;
    private readonly InputAction m_Player_Primary_Right;
    private readonly InputAction m_Player_Secondary_Right;
    private readonly InputAction m_Player_Primary_Left;
    private readonly InputAction m_Player_Secondary_Left;
    public struct PlayerActions
    {
        private @Phyzk_Player m_Wrapper;
        public PlayerActions(@Phyzk_Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @Left_Joystick => m_Wrapper.m_Player_Left_Joystick;
        public InputAction @Right_Joystick => m_Wrapper.m_Player_Right_Joystick;
        public InputAction @Grip_Left => m_Wrapper.m_Player_Grip_Left;
        public InputAction @Grip_Right => m_Wrapper.m_Player_Grip_Right;
        public InputAction @Trigger_Left => m_Wrapper.m_Player_Trigger_Left;
        public InputAction @Trigger_Right => m_Wrapper.m_Player_Trigger_Right;
        public InputAction @Primary_Right => m_Wrapper.m_Player_Primary_Right;
        public InputAction @Secondary_Right => m_Wrapper.m_Player_Secondary_Right;
        public InputAction @Primary_Left => m_Wrapper.m_Player_Primary_Left;
        public InputAction @Secondary_Left => m_Wrapper.m_Player_Secondary_Left;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Left_Joystick.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeft_Joystick;
                @Left_Joystick.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeft_Joystick;
                @Left_Joystick.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeft_Joystick;
                @Right_Joystick.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRight_Joystick;
                @Right_Joystick.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRight_Joystick;
                @Right_Joystick.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRight_Joystick;
                @Grip_Left.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGrip_Left;
                @Grip_Left.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGrip_Left;
                @Grip_Left.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGrip_Left;
                @Grip_Right.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGrip_Right;
                @Grip_Right.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGrip_Right;
                @Grip_Right.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGrip_Right;
                @Trigger_Left.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTrigger_Left;
                @Trigger_Left.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTrigger_Left;
                @Trigger_Left.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTrigger_Left;
                @Trigger_Right.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTrigger_Right;
                @Trigger_Right.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTrigger_Right;
                @Trigger_Right.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTrigger_Right;
                @Primary_Right.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPrimary_Right;
                @Primary_Right.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPrimary_Right;
                @Primary_Right.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPrimary_Right;
                @Secondary_Right.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSecondary_Right;
                @Secondary_Right.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSecondary_Right;
                @Secondary_Right.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSecondary_Right;
                @Primary_Left.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPrimary_Left;
                @Primary_Left.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPrimary_Left;
                @Primary_Left.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPrimary_Left;
                @Secondary_Left.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSecondary_Left;
                @Secondary_Left.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSecondary_Left;
                @Secondary_Left.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSecondary_Left;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Left_Joystick.started += instance.OnLeft_Joystick;
                @Left_Joystick.performed += instance.OnLeft_Joystick;
                @Left_Joystick.canceled += instance.OnLeft_Joystick;
                @Right_Joystick.started += instance.OnRight_Joystick;
                @Right_Joystick.performed += instance.OnRight_Joystick;
                @Right_Joystick.canceled += instance.OnRight_Joystick;
                @Grip_Left.started += instance.OnGrip_Left;
                @Grip_Left.performed += instance.OnGrip_Left;
                @Grip_Left.canceled += instance.OnGrip_Left;
                @Grip_Right.started += instance.OnGrip_Right;
                @Grip_Right.performed += instance.OnGrip_Right;
                @Grip_Right.canceled += instance.OnGrip_Right;
                @Trigger_Left.started += instance.OnTrigger_Left;
                @Trigger_Left.performed += instance.OnTrigger_Left;
                @Trigger_Left.canceled += instance.OnTrigger_Left;
                @Trigger_Right.started += instance.OnTrigger_Right;
                @Trigger_Right.performed += instance.OnTrigger_Right;
                @Trigger_Right.canceled += instance.OnTrigger_Right;
                @Primary_Right.started += instance.OnPrimary_Right;
                @Primary_Right.performed += instance.OnPrimary_Right;
                @Primary_Right.canceled += instance.OnPrimary_Right;
                @Secondary_Right.started += instance.OnSecondary_Right;
                @Secondary_Right.performed += instance.OnSecondary_Right;
                @Secondary_Right.canceled += instance.OnSecondary_Right;
                @Primary_Left.started += instance.OnPrimary_Left;
                @Primary_Left.performed += instance.OnPrimary_Left;
                @Primary_Left.canceled += instance.OnPrimary_Left;
                @Secondary_Left.started += instance.OnSecondary_Left;
                @Secondary_Left.performed += instance.OnSecondary_Left;
                @Secondary_Left.canceled += instance.OnSecondary_Left;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    private int m_XRSchemeIndex = -1;
    public InputControlScheme XRScheme
    {
        get
        {
            if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
            return asset.controlSchemes[m_XRSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnLeft_Joystick(InputAction.CallbackContext context);
        void OnRight_Joystick(InputAction.CallbackContext context);
        void OnGrip_Left(InputAction.CallbackContext context);
        void OnGrip_Right(InputAction.CallbackContext context);
        void OnTrigger_Left(InputAction.CallbackContext context);
        void OnTrigger_Right(InputAction.CallbackContext context);
        void OnPrimary_Right(InputAction.CallbackContext context);
        void OnSecondary_Right(InputAction.CallbackContext context);
        void OnPrimary_Left(InputAction.CallbackContext context);
        void OnSecondary_Left(InputAction.CallbackContext context);
    }
}
