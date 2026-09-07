using UnityEngine;
using UnityEngine.InputSystem;

public class CameraZoom : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float zoomSpeed = 0.002f;
    [SerializeField] private float minimumDistance = 1.2f;
    [SerializeField] private float maximumDistance = 6f;

    private void Update()
    {
        if (Mouse.current == null || target == null)
            return;

        float scroll = Mouse.current.scroll.ReadValue().y;

        if (Mathf.Abs(scroll) < 0.01f)
            return;

        Vector3 direction =
            (transform.position - target.position).normalized;

        float distance = Vector3.Distance(
            transform.position,
            target.position
        );

        distance -= scroll * zoomSpeed;

        distance = Mathf.Clamp(
            distance,
            minimumDistance,
            maximumDistance
        );

        transform.position =
            target.position + direction * distance;
    }
}