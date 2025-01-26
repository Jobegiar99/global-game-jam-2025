using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public Vector3 offset = new Vector3(0, 2, -10); // Camera offset

    void LateUpdate()
    {
        Vector3 targetPosition = new Vector3(player.position.x, player.position.y, player.position.z) + offset;
        transform.position = targetPosition;
    }
}
