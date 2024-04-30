using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 4.0f; //The f at the end of the number denotes is a floating-point number
    [SerializeField] float rotateSpeed = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Player started");
    }

 
        void Update()
        {
            float speed = Input.GetAxis("Vertical");

            //Set animation
            // If the player is moving
            if (speed != 0)
            {
                GetComponent<Animator>().SetBool("forward", true);
            }
            else// If the player is not moving
            {
                GetComponent<Animator>().SetBool("forward", false);
            }

            // Rotate around y-axis
            transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);

            // Forward is the forward direction for this character
            Vector3 forward = transform.TransformDirection(Vector3.forward);

            // You need the Character Controller so you can use SimpleMove
            CharacterController controller = GetComponent<CharacterController>();
            controller.SimpleMove(forward * speed * moveSpeed);
 
    }
}
