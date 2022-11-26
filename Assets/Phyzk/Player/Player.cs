using UnityEngine;

namespace Phyzk
{
    public class Player : MonoBehaviour
    {
        #region Declarations

        [SerializeField] private Rigidbody rb;
        [SerializeField] private float forwardSpeed;
        [SerializeField] private float forwardDecelerationRate;
        [SerializeField] private float horizontalSpeed;
        [SerializeField] private float horizontalDecelerationRate;
        [SerializeField] private float turnSpeed;
        public GameObject body;
        
        #endregion

        #region Unity Methods

        private void Start()
        {
            InputManager.instance.onLeftJoystick += Move;
            InputManager.instance.onRightJoystick += Turn;
            InputManager.instance.onGripLeft += LeftGrab;
            InputManager.instance.onGripRight += RightGrab;
            InputManager.instance.onTriggerLeft += LeftTrigger;
            InputManager.instance.onTriggerRight += RightTrigger;
            InputManager.instance.onPrimaryLeft += PrimaryButtonLeft;
            InputManager.instance.onSecondaryLeft += SecondaryButtonLeft;
            InputManager.instance.onPrimaryRight += PrimaryButtonRight;
            InputManager.instance.onSecondaryRight += SecondaryButtonRight;
        }

        #endregion
        
        #region Custom Methods
        
        public void Move(Vector2 moveVect)
        {
            Vector3 fwdVect = Vector3.zero;
            Vector3 horizVect = Vector3.zero;
            if (moveVect.y <= 0.1f)
            {
                fwdVect = body.transform.right * -forwardDecelerationRate;
            }
            else
            {
                fwdVect = body.transform.right * moveVect.y * forwardSpeed;
            }
            
            if (moveVect.x <= 0.1f)
            {
                horizVect = body.transform.forward * - horizontalDecelerationRate;
            }
            else
            {
                horizVect = body.transform.forward * -moveVect.x * horizontalSpeed;
            }

            rb.AddTorque(fwdVect + horizVect);
           
            // Debug.Log("fwd " + fwdVect);
            // Debug.Log("horiz " + horizVect);
        }
        
        public void Turn(Vector2 turnVect)
        {
            body.transform.Rotate(Vector3.up * turnVect.x * turnSpeed);
        }
        
        public void LeftGrab(float val)
        {
            
        }
        
        public void RightGrab(float val)
        {
            
        }
        
        public void LeftTrigger(float val)
        {
            
        }
        
        public void RightTrigger(float val)
        {
            
        }

        public void PrimaryButtonLeft(bool val)
        {
            
        }
        
        public void SecondaryButtonLeft(bool val)
        {
            
        }
        
        public void PrimaryButtonRight(bool val)
        {
            
        }
        
        public void SecondaryButtonRight(bool val)
        {
            
        }
        
        #endregion
    }
}