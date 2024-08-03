using UnityEngine;

public class FPSMouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform playerBody;
    public Transform playerHead;

    private float rotationX = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -50f, 40f); // Yukarı aşağı sınırlama

        playerHead.localRotation = Quaternion.Euler(rotationX, 0f, 0f); // Başın yukarı aşağı dönmesi

        playerBody.Rotate(Vector3.up * mouseX); // Vücudun sağa sola dönmesi
    }
}
