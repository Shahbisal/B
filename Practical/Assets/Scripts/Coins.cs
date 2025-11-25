using UnityEngine;

public class RotateAndDestroy : MonoBehaviour
{
    public float rotationSpeed = 50f;

    void Update()
    {
        // Rotate around Y axis
        transform.Rotate(rotationSpeed * Time.deltaTime, 0 , 0);
    }

}
