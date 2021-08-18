using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkipinGame
{


    public class PlayerController : MonoBehaviour
    {
        public float Speed = 3.0f;
        public float JumpSpeed  = 125.0f;
        private Rigidbody _rigidbody;

        
       private Vector3 _movement;
       private  Quaternion _rotation = Quaternion.identity;

        private bool _isGround;

        void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
            Cursor.lockState = CursorLockMode.Locked;
        }


        protected void Move()
        {
            
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            
            Vector3 movement = new Vector3(-moveHorizontal, 0.0f, -moveVertical);
                
            _rigidbody.AddForce(movement * Speed);
            

        }


        protected void Jumping()
        {
            if (Input.GetAxis("Jump") > 0)
            {
                if (_isGround)
                {
                    _rigidbody.AddForce(Vector3.up * JumpSpeed);
                }
            }
        }

        private void OnCollisionEnter(Collision collision)
        {

            IsGroundedUpate(collision, true);
            
        }

        private void OnCollisionExit(Collision collision)
        {
            IsGroundedUpate(collision, false);
        }

        private void IsGroundedUpate(Collision collision, bool value)
        {
            if (collision.gameObject.tag == ("Ground"))
            {
                _isGround = value;
            }
        }
        
    }
}
