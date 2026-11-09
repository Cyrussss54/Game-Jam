using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [Header("Target")]
    public Transform target; // Drag your player here in the Inspector

    [Header("Settings")]
    public float smoothSpeed = 0.125f; // Lower = smoother/slower, Higher = tighter/faster
    public Vector3 offset; // Distance/offset between the camera and the player

    void LateUpdate()
    {
        if (target == null) return;

        // Calculate the desired position
        Vector3 desiredPosition = target.position + offset;

        // Smoothly move towards the desired position using Lerp
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Update the camera's position
        transform.position = smoothedPosition;
    }
}