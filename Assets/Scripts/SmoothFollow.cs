using UnityEngine;
using System.Collections;
namespace UnityStandardAssets.Utility
{
    public class SmoothFollow : MonoBehaviour
    {

        // The target we are following
        [SerializeField]
        private Transform target;
        // The distance in the x-z plane to the target
        [SerializeField]
        private float distance = 13.0f;
        // the height we want the camera to be above the target
        //[SerializeField]
        private float height = 5.0f;
        private float playerCameraDist;
        private float xRotate;


        [SerializeField]
        private float rotationDamping = 3f;
        [SerializeField]
        private float heightDamping;

        public float speedH;
        public float speedV;

        private float xRotation = 0f;
        private float yRotation = 0f;

        // Use this for initialization
        void Start()
        {

            target = GameObject.FindGameObjectWithTag("Player").transform;

        }

        void Update()
        {

            if (Input.GetMouseButton(1))
            {
                xRotation += speedH * Input.GetAxis("Mouse X");
                //yRotation -= speedV * Input.GetAxis("Mouse Y");


                transform.eulerAngles = new Vector3(0, xRotation, 0.0f);
            }

            // Gets the input of the mouse scroll
            float mouseScroll = Input.mouseScrollDelta.y;

            // Calculate the distance and how mant times the mouse scroll happened
            distance = distance - mouseScroll;

            int dist = (int)distance; // Convert float distance to an int to use in switch-case statement
            switch (dist)
            {
                case 4:
                    height = 2.5f;
                    break;
                case 5:
                    height = 3f;
                    break;
                case 6:
                    height = 4f;
                    break;
                case 7:
                    height = 5f;
                    break;
                case 8:
                    height = 6f;
                    break;
                case 9:
                    height = 7f;
                    break;
                case 10:
                    height = 9f;
                    break;
                case 11:
                    height = 10f;
                    break;
                case 12:
                    height = 11f;
                    break;
                case 13:
                    height = 13;
                    break;
            }

            //Locks the distance at eight 
            if (distance > 13.1f)
            {
                distance = 13.0f;
            }

            // Locks the distance at four
            if ((distance < 3.9f && distance > 0.1f) || (distance < 0))
            {
                distance = 4.0f;
            }

            // Changes the mouse depending on how the mouse is looking
            if (Input.GetMouseButtonDown(2))
            {
                if (distance > 0.1f)
                {
                    distance = 0.0f;
                }

                else
                {
                    distance = 8.0f;
                }

            }
        }

        // Update is called once per frame
        void LateUpdate()
        {
            // Early out if we don't have a target
            if (!target)
                return;


            
            // Calculate the current rotation angles
            var wantedRotationAngle = -(target.eulerAngles.y);
            var wantedHeight = -(target.position.y + height);

            var currentRotationAngleY = transform.eulerAngles.y;
            var currentHeight = transform.position.y;

            
            var wantedRotationAngleX = target.eulerAngles.x;
            var wantedHeightX = target.position.x + height;
            var currentRotationAngleX = transform.eulerAngles.x;
            var currentXHeight = transform.position.x;
            

            // Damp the rotation around the y-axis
            currentRotationAngleY = Mathf.LerpAngle(currentRotationAngleY, wantedRotationAngle, rotationDamping * Time.deltaTime);
            //currentRotationAngleX = Mathf.LerpAngle(currentRotationAngleX, wantedRotationAngleX, rotationDamping * Time.deltaTime);
            // Debug.Log(currentRotationAngleY);

            // Damp the height
             currentHeight = Mathf.Lerp(currentHeight, wantedHeight, heightDamping * Time.deltaTime);
            // Debug.Log("Current Height: " + currentHeight);

            // Convert the angle into a rotation
            //var currentRotation = Quaternion.Euler(currentRotationAngleX, currentRotationAngleY, 0);
            var currentRotation = Quaternion.Euler(0, currentRotationAngleY, 0);
            //Debug.Log(currentRotation);

            // Set the position of the camera on the x-z plane to:
            // distance meters behind the target
            transform.position = target.position;
            transform.position -= currentRotation * Vector3.forward * (distance-0.5f);
             Debug.Log(transform.position);
            
            // Set the height of the camera
            transform.position = new Vector3(transform.position.x, height, transform.position.z);
            Debug.Log("New Position:" + transform.position);


            // Always look at the target
            transform.LookAt(target);



        }

        /* 
        Switches between Players one, two and three
        The code now only assumes that there are only three players
        And will always be three players
        */
        public void SwitchTarget()
        {
            if (target.tag == "Player")
                target = GameObject.FindGameObjectWithTag("Player2").transform;

            else if (target.tag == "Player2")
                target = GameObject.FindGameObjectWithTag("Player3").transform;

            else if (target.tag == "Player3")
                target = GameObject.FindGameObjectWithTag("Player").transform;

        }
    }
}