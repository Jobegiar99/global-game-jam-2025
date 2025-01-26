using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    Animator animator;

    int isWalkingHash;
    int isRunningHash;

    Vector3 movementInput; // Tracks input direction
    bool runPressed;

    float turnSpeed = 200f; // Rotation speed

    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
    }

    void Update()
    {
        ProcessInput();
        HandleMovement();
    }

    void ProcessInput()
    {
        // Get WASD movement input
        float horizontal = Input.GetAxis("Horizontal"); // A/D for turning
        float vertical = Input.GetAxis("Vertical");     // W/S for forward/backward

        movementInput = new Vector3(0, 0, vertical); // Forward/backward movement only

        // Rotate the character based on horizontal input (A/D)
        transform.Rotate(0, horizontal * turnSpeed * Time.deltaTime, 0);

        // Get running input
        runPressed = Input.GetKey(KeyCode.LeftShift);
    }

    void HandleMovement()
    {
        // Check if there's any movement input
        bool isMoving = movementInput.magnitude > 0;

        // Set walking state
        animator.SetBool(isWalkingHash, isMoving);

        // Set running state
        animator.SetBool(isRunningHash, isMoving && runPressed);

        // Move the character forward or backward
        if (isMoving)
        {
            Vector3 moveDirection = transform.forward * movementInput.z;
            transform.position += moveDirection * (runPressed ? 5f : 2f) * Time.deltaTime; // Faster if running
        }
    }
}
