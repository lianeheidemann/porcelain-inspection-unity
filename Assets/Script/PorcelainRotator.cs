using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class PorcelainRotator : MonoBehaviour
{
    [SerializeField] private float rotationSensitivity = 0.25f;
    [SerializeField] private float minimumVerticalAngle = -25f;
    [SerializeField] private float maximumVerticalAngle = 25f;

    private float horizontalAngle;
    private float verticalAngle;
    private bool isDragging;

    private void Start()
    {
        Vector3 initialRotation = transform.eulerAngles;
        horizontalAngle = initialRotation.y;
        verticalAngle = NormalizeAngle(initialRotation.x);
    }

    private void Update()
    {
        Vector2 movement = Vector2.zero;

        // Mouse no computador
        if (Mouse.current != null)
        {
            if (Mouse.current.leftButton.wasPressedThisFrame)
            {
                isDragging = !IsPointerOverUI();
            }

            if (Mouse.current.leftButton.wasReleasedThisFrame)
            {
                isDragging = false;
            }

            if (isDragging && Mouse.current.leftButton.isPressed)
            {
                movement = Mouse.current.delta.ReadValue();
            }
        }

        // Toque na tela do celular
        if (Touchscreen.current != null)
        {
            var touch = Touchscreen.current.primaryTouch;

            if (touch.press.wasPressedThisFrame)
            {
                isDragging = !IsPointerOverUI();
            }

            if (touch.press.wasReleasedThisFrame)
            {
                isDragging = false;
            }

            if (isDragging && touch.press.isPressed)
            {
                movement = touch.delta.ReadValue();
            }
        }

        RotatePorcelain(movement);
    }

    private void RotatePorcelain(Vector2 movement)
    {
        if (movement.sqrMagnitude <= 0f)
            return;

        horizontalAngle -= movement.x * rotationSensitivity;
        verticalAngle += movement.y * rotationSensitivity;

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

    private bool IsPointerOverUI()
    {
        return EventSystem.current != null &&
               EventSystem.current.IsPointerOverGameObject();
    }

    private float NormalizeAngle(float angle)
    {
        if (angle > 180f)
            angle -= 360f;

        return angle;
    }
}