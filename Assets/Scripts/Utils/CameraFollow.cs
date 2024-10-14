using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float FollowSpeed;
    public float Height;
    public Transform target;
    public Vector2 Max;
    public Vector2 Min;
    private const float positionZ = -10f;

    // Update is called once per frame
    void Update()
    {
        this.CameraToPlayer();
    }

    private void CameraToPlayer()
    {
        // Calculate the target position with height offset
        Vector3 targetPos = new(target.position.x, target.position.y + Height, positionZ);

        // Clamp the target position within the bounds
        targetPos.x = Mathf.Clamp(targetPos.x, Min.x, Max.x);
        targetPos.y = Mathf.Clamp(targetPos.y, Min.y, Max.y);

        // Smoothly move the camera towards the target
        transform.position = Vector3.Lerp(transform.position, targetPos, FollowSpeed * Time.deltaTime);
    }
}
