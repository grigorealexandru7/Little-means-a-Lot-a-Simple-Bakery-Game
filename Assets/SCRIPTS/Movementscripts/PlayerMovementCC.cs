using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1000f;
    public float jump = 30f;
    public float gravity = -9.81f;
    
    private CharacterController controller;
    private Vector3 velocity;
    void Start()
    {
        controller=GetComponent<CharacterController>();
    }
    
    void Update()
    {
        Vector3 move= transform.right * Input.GetAxis("Horizontal") + transform.forward * Input.GetAxis("Vertical");
        controller.Move(move * speed * Time.deltaTime);
        if (controller.isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            velocity.y = Mathf.Sqrt(jump * -2f * gravity);
        }
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
