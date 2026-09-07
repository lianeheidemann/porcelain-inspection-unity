using UnityEngine;
using UnityEngine.InputSystem;

public class PorcelainRotator : MonoBehaviour
{
    [SerializeField] private float rotationSensitivity = 0.25f;
    [SerializeField] private float minimumVerticalAngle = -25f;
    [SerializeField] private float maximumVerticalAngle = 25f;

    private float horizontalAngle;
    private float verticalAngle;

    private void Start()
    {
        Vector3 initialRotation = transform.eulerAngles;
        horizontalAngle = initialRotation.y;
        verticalAngle = NormalizeAngle(initialRotation.x);
    }

    private void Update()
    {
        if (Mouse.current == null)
            return;

        if (Mouse.current.leftButton.isPressed)
        {
            Vector2 mouseDelta = Mouse.current.delta.ReadValue();

            horizontalAngle -= mouseDelta.x * rotationSensitivity;
            verticalAngle += mouseDelta.y * rotationSensitivity;

            verticalAngle = Mathf.Clamp(
                verticalAngle,
                minimumVerticalAngle,
                maximumVerticalAngle
            );

            transform.rotation = Quaternion.Euler(
                verticalAngle,
                horizontalAngle,
                0f
            );
        }
    }

    private float NormalizeAngle(float angle)
    {
        if (angle > 180f)
            angle -= 360f;

        return angle;
    }
}