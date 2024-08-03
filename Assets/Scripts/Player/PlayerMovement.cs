using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float walkSpeed = 2f;
    public float runSpeed = 5f;
    public float mouseSensitivity = 100f;
    public Transform playerCamera;

    private bool isIdle = true;
    private bool isWalking = false;
    private bool isRunning = false;

    private Animator animator;
    private float xRotation = 0f;

    private void Start()
    {
        animator = GetComponent<Animator>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        HandleMovement();
        HandleCameraRotation();
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

    private void HandleCameraRotation()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        playerCamera.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.Rotate(Vector3.up * mouseX);
    }

    private void UpdateAnimator()
    {
        animator.SetBool("isIdle", isIdle);
        animator.SetBool("isWalking", isWalking);
        animator.SetBool("isRunning", isRunning);
    }
}
