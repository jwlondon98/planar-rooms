﻿using UnityEngine;
using UnityEngine.InputSystem;

namespace EvolveGames
{
    [RequireComponent(typeof(CharacterController))]
    public class PlayerController : MonoBehaviour
    {
        [Header("PlayerController")]
        [SerializeField] public Transform Camera;
        [SerializeField, Range(1, 10)] float walkingSpeed = 3.0f;
        [Range(0.1f, 5)] public float CroughSpeed = 1.0f;
        [SerializeField, Range(2, 20)] float RuningSpeed = 4.0f;
        [SerializeField, Range(0, 20)] float jumpSpeed = 6.0f;
        [SerializeField, Range(0.1f, 10)] float lookSpeed = 2.0f;
        [SerializeField, Range(10, 120)] float lookXLimit = 80.0f;
        [Space(20)]
        [Header("Advance")]
        [SerializeField] float RunningFOV = 65.0f;
        [SerializeField] float SpeedToFOV = 4.0f;
        [SerializeField] float CroughHeight = 1.0f;
        [SerializeField] float gravity = 20.0f;
        [SerializeField] float timeToRunning = 2.0f;
        [HideInInspector] public bool canMove = true;
        [HideInInspector] public bool CanRunning = true;

        [Space(20)]
        [Header("Climbing")]
        [SerializeField] bool CanClimbing = true;
        [SerializeField, Range(1, 25)] float Speed = 2f;
        bool isClimbing = false;

        [Space(20)]
        [Header("HandsHide")]
        [SerializeField] bool CanHideDistanceWall = true;
        [SerializeField, Range(0.1f, 5)] float HideDistance = 1.5f;
        [SerializeField] int LayerMaskInt = 1;

        [HideInInspector] public CharacterController characterController;
        [HideInInspector] public Vector3 moveDirection = Vector3.zero;
        bool isCrough = false;
        float InstallCroughHeight;
        float rotationX = 0;
        [HideInInspector] public bool isRunning = false;
        Vector3 InstallCameraMovement;
        float InstallFOV;
        Camera cam;
        [HideInInspector] public bool Moving;
        [HideInInspector] public float vertical;
        [HideInInspector] public float horizontal;
        [HideInInspector] public float Lookvertical;
        [HideInInspector] public float Lookhorizontal;
        float RunningValue;
        float installGravity;
        bool WallDistance;
        [HideInInspector] public float WalkingValue;

        void Start()
        {
            characterController = GetComponent<CharacterController>();
            cam = GetComponentInChildren<Camera>();
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            InstallCroughHeight = characterController.height;
            InstallCameraMovement = Camera.localPosition;
            InstallFOV = cam.fieldOfView;
            RunningValue = RuningSpeed;
            installGravity = gravity;
            WalkingValue = walkingSpeed;
        }

        void Update()
        {
            RaycastHit CroughCheck;
            RaycastHit ObjectCheck;

            Keyboard keyboard = Keyboard.current;
 
            if (!characterController.isGrounded && !isClimbing)
            {
                moveDirection.y -= gravity * Time.deltaTime;
            }
            Vector3 forward = transform.TransformDirection(Vector3.forward);
            Vector3 right = transform.TransformDirection(Vector3.right);
            isRunning = !isCrough ? CanRunning ? keyboard.leftShiftKey.wasPressedThisFrame : false : false;
            var vert = keyboard.wKey.isPressed ? 1 : keyboard.sKey.isPressed ? -1 : 0;
            var horiz = keyboard.dKey.isPressed ? 1 : keyboard.aKey.isPressed ? -1 : 0;
            
            vertical = canMove ? (isRunning ? RunningValue : WalkingValue) * vert : 0;
            horizontal = canMove ? (isRunning ? RunningValue : WalkingValue) * horiz : 0;
            if (isRunning) RunningValue = Mathf.Lerp(RunningValue, RuningSpeed, timeToRunning * Time.deltaTime);
            else RunningValue = WalkingValue;
            float movementDirectionY = moveDirection.y;
            moveDirection = (forward * vertical) + (right * horizontal);

            if (keyboard.spaceKey.wasPressedThisFrame && canMove && characterController.isGrounded && !isClimbing)
            {
                moveDirection.y = jumpSpeed;
            }
            else
            {
                moveDirection.y = movementDirectionY;
            }
            characterController.Move(moveDirection * Time.deltaTime);
            Moving = horizontal < 0 || vertical < 0 || horizontal > 0 || vertical > 0 ? true : false;

            if (isRunning && Moving) cam.fieldOfView = Mathf.Lerp(cam.fieldOfView, RunningFOV, SpeedToFOV * Time.deltaTime);
            else cam.fieldOfView = Mathf.Lerp(cam.fieldOfView, InstallFOV, SpeedToFOV * Time.deltaTime);

            if (keyboard.leftCtrlKey.wasPressedThisFrame)
            {
                isCrough = true;
                float Height = Mathf.Lerp(characterController.height, CroughHeight, 5 * Time.deltaTime);
                characterController.height = Height;
                WalkingValue = Mathf.Lerp(WalkingValue, CroughSpeed, 6 * Time.deltaTime);

            }
            else if (!Physics.Raycast(GetComponentInChildren<Camera>().transform.position, transform.TransformDirection(Vector3.up), out CroughCheck, 0.8f, 1))
            {
                if (characterController.height != InstallCroughHeight)
                {
                    isCrough = false;
                    float Height = Mathf.Lerp(characterController.height, InstallCroughHeight, 6 * Time.deltaTime);
                    characterController.height = Height;
                    WalkingValue = Mathf.Lerp(WalkingValue, walkingSpeed, 4 * Time.deltaTime);
                }
            }

            if(WallDistance != Physics.Raycast(GetComponentInChildren<Camera>().transform.position, transform.TransformDirection(Vector3.forward), out ObjectCheck, HideDistance, LayerMaskInt) && CanHideDistanceWall)
            {
                WallDistance = Physics.Raycast(GetComponentInChildren<Camera>().transform.position, transform.TransformDirection(Vector3.forward), out ObjectCheck, HideDistance, LayerMaskInt);
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            // if (other.tag == "Ladder" && CanClimbing)
            // { 
            //     CanRunning = false;
            //     isClimbing = true;
            //     WalkingValue /= 2;
            // }
        }
        private void OnTriggerStay(Collider other)
        {
            // if (other.tag == "Ladder" && CanClimbing)
            // {
            //     moveDirection = new Vector3(0, Input.GetAxis("Vertical") * Speed * (-Camera.localRotation.x / 1.7f), 0);
            // }
        }
        private void OnTriggerExit(Collider other)
        {
            // if (other.tag == "Ladder" && CanClimbing)
            // {
            //     CanRunning = true;
            //     isClimbing = false;
            //     WalkingValue *= 2;
            // }
        }

    }
}