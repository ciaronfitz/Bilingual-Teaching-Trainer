using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    private Transform mainCameraTransform;
    [SerializeField] private Camera Camera; // [1

    void Start()
    {
        // Find the main camera in the scene
        mainCameraTransform = Camera.transform;
    }

    void LateUpdate()
    {
        // Make the head look at the camera
        LookAt(mainCameraTransform);
    }

    private void LookAt(Transform target)
    {
        // Calculate the direction from the head to the camera
        Vector3 direction = target.position - transform.position;

        // Calculate the new rotation
        Quaternion rotation = Quaternion.LookRotation(direction);

        // Apply the rotation to the head
        transform.rotation = rotation;
    }
}