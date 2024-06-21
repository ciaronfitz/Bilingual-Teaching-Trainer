using UnityEngine;

public class PointAtObject : MonoBehaviour
{
    private Transform objectTransform;
    [SerializeField] private GameObject objectToPointAt; // [1

    void Start()
    {
        // Find the main camera in the scene
        objectTransform = objectToPointAt.transform;
    }

    void LateUpdate()
    {
        // Make the head look at the camera
        PointAt(objectTransform);
    }

    private void PointAt(Transform target)
    {
        // Calculate the direction from the head to the camera
        Vector3 direction = target.position - transform.position;

        // Calculate the new rotation
        Quaternion rotation = Quaternion.LookRotation(direction);

        // Apply the rotation to the head
        transform.rotation = rotation;
    }
}