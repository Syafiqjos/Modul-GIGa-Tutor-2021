using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
    public bool isFollowing = true;
    public Transform target;

    private Vector3 targetPos;
    public Vector3 targetOffset;

    [Range(0, 1.0f)] public float followRatio = 1.0f;

    void Update()
    {
        if (target)
        {
            if (isFollowing)
            {
                targetPos = target.position;
            }

            Vector3 newPos = Vector3.Lerp(transform.position, targetPos, followRatio) + targetOffset;
            newPos.z = transform.position.z;

            transform.position = newPos;
        }
    }
}
