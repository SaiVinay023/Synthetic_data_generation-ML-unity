using UnityEngine;

public class RotateRightLeft : MonoBehaviour
{
    public float rotationSpeed = 2f; // Speed of rotation
    public float maxRotation = 5f; // Maximum rotation angle in degrees
    private Quaternion initialRotation;
    private float currentRotation = 0f;
    private bool rotatingRight = true;

    void Start()
    {
        // Store the initial rotation of the object
        initialRotation = transform.rotation;
    }

    void Update()
    {
        // Calculate the rotation amount based on the direction of rotation
        float rotationAmount = maxRotation * Time.deltaTime * rotationSpeed;

        // Update the current rotation based on the direction
        currentRotation += rotatingRight ? rotationAmount : -rotationAmount;

        // Apply rotation to the object
        transform.rotation = initialRotation * Quaternion.Euler(0, currentRotation, 0);

        // Check if the object has reached the maximum rotation and change direction
        if (Mathf.Abs(currentRotation) >= maxRotation)
        {
            rotatingRight = !rotatingRight;
        }
    }
}
