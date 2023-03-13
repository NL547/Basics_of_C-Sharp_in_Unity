using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public class Player : MonoBehaviour
    {
        public float moveSpeed;
        public Rigidbody _rb;

        public GameObject MainCamera;

        public bool highVision;

        //public delegate void HighVisionDelegate();
        //HighVisionDelegate highVisionDelegate;

        void Start()
        {
            _rb = GetComponent<Rigidbody>();           
        }        

        protected void Move()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            _rb.AddForce(movement * moveSpeed);
        }

        private void ResetHighVision()
        {
            highVision = false;
            Camera.main.fieldOfView = 82.0f;
        }

        void OnTriggerStay(Collider coll)
        {
            if (coll.tag == "HighVisionItem")
            {
                highVision = true;
                Destroy(coll.gameObject);
                Camera.main.fieldOfView = 150.0f;
                Invoke(nameof(ResetHighVision), 20f);
            }
        }
    }
}
