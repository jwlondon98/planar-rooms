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
                },
                {
                    ""name"": ""W"",
                    ""type"": ""Button"",
                    ""id"": ""cce8ae9b-6d3e-4be1-98f9-952f130ac15d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""A"",
                    ""type"": ""Button"",
                    ""id"": ""605cc813-a66e-43bf-b9b5-aadb04454e97"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""S"",
                    ""type"": ""Button"",
                    ""id"": ""4c14490c-9cfa-4c88-8010-3c2d6b77c1e0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""D"",
                    ""type"": ""Button"",
                    ""id"": ""0ccd67c1-9d01-44cb-af39-00f2daa5e5b5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""a0258237-9c43-4bcb-a21e-6c720fc154ee"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""28cdcc94-b23c-42ef-b997-4b7e030fe3e0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""eeaa2113-309c-465a-9f68-b2e25b58c080"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Mouse Pos"",
                    ""type"": ""Value"",
                    ""id"": ""c4777f7c-4777-4f5e-9528-a49a99906258"",
                    ""expectedControlType"": ""Vector2"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""c6080b9a-deee-4700-945b-93e27443cb7e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""W"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""824c02aa-577c-4dd4-9aa6-719041284024"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""S"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""814cf9d3-93cf-41b6-b788-94ce99d1ae25"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""D"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3fa9ac37-4bcb-4eff-8630-5a1d1ddd9183"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fc006b47-f55e-45f7-be47-890e932fefb9"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Mouse Pos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8dd57866-0036-412d-a2e6-89e830f49611"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0d71eff2-a5d9-4312-b554-ee0e0f92f2a9"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""96d24125-1335-4636-a445-18f8a3b05fd5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Jump"",
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
        m_Player_W = m_Player.FindAction("W", throwIfNotFound: true);
        m_Player_A = m_Player.FindAction("A", throwIfNotFound: true);
        m_Player_S = m_Player.FindAction("S", throwIfNotFound: true);
        m_Player_D = m_Player.FindAction("D", throwIfNotFound: true);
        m_Player_Crouch = m_Player.FindAction("Crouch", throwIfNotFound: true);
        m_Player_Sprint = m_Player.FindAction("Sprint", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_MousePos = m_Player.FindAction("Mouse Pos", throwIfNotFound: true);
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
    private readonly InputAction m_Player_W;
    private readonly InputAction m_Player_A;
    private readonly InputAction m_Player_S;
    private readonly InputAction m_Player_D;
    private readonly InputAction m_Player_Crouch;
    private readonly InputAction m_Player_Sprint;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_MousePos;
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
        public InputAction @W => m_Wrapper.m_Player_W;
        public InputAction @A => m_Wrapper.m_Player_A;
        public InputAction @S => m_Wrapper.m_Player_S;
        public InputAction @D => m_Wrapper.m_Player_D;
        public InputAction @Crouch => m_Wrapper.m_Player_Crouch;
        public InputAction @Sprint => m_Wrapper.m_Player_Sprint;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @MousePos => m_Wrapper.m_Player_MousePos;
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
                @W.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnW;
                @W.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnW;
                @W.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnW;
                @A.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnA;
                @A.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnA;
                @A.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnA;
                @S.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnS;
                @S.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnS;
                @S.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnS;
                @D.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnD;
                @D.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnD;
                @D.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnD;
                @Crouch.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                @Sprint.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @MousePos.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMousePos;
                @MousePos.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMousePos;
                @MousePos.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMousePos;
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
                @W.started += instance.OnW;
                @W.performed += instance.OnW;
                @W.canceled += instance.OnW;
                @A.started += instance.OnA;
                @A.performed += instance.OnA;
                @A.canceled += instance.OnA;
                @S.started += instance.OnS;
                @S.performed += instance.OnS;
                @S.canceled += instance.OnS;
                @D.started += instance.OnD;
                @D.performed += instance.OnD;
                @D.canceled += instance.OnD;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @MousePos.started += instance.OnMousePos;
                @MousePos.performed += instance.OnMousePos;
                @MousePos.canceled += instance.OnMousePos;
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
        void OnW(InputAction.CallbackContext context);
        void OnA(InputAction.CallbackContext context);
        void OnS(InputAction.CallbackContext context);
        void OnD(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnMousePos(InputAction.CallbackContext context);
    }
}
