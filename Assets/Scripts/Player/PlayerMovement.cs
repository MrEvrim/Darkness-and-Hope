using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float walkSpeed = 2f;
    public float runSpeed = 5f;
    public float mouseSensitivity = 100f;

    private bool isIdle = true;
    private bool isWalking = false;
    private bool isRunning = false;

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        HandleMovement();
        UpdateAnimator();
    }

    private void HandleMovement()
    {
        float moveHorizontal = 0f;
        float moveVertical = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            moveVertical = 1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveVertical = -1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveHorizontal = -1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveHorizontal = 1f;
        }

        Vector3 movement = transform.right * moveHorizontal + transform.forward * moveVertical;

        if (movement.magnitude > 0)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                // Running
                transform.Translate(movement * runSpeed * Time.deltaTime, Space.World);
                isRunning = true;
                isWalking = false;
                isIdle = false;
            }
            else
            {
                // Walking
                transform.Translate(movement * walkSpeed * Time.deltaTime, Space.World);
                isWalking = true;
                isRunning = false;
                isIdle = false;
            }
        }
        else
        {
            // Idle
            isIdle = true;
            isWalking = false;
            isRunning = false;
        }
    }
    private void UpdateAnimator()
    {
        animator.SetBool("isIdle", isIdle);
        animator.SetBool("isWalking", isWalking);
        animator.SetBool("isRunning", isRunning);
    }
}
