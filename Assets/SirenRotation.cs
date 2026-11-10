using UnityEngine;

public class SirenRotation : MonoBehaviour
{
    // Velocidad de giro en grados por segundo (editable en el Inspector)
    public float rotationSpeed = 240f;

    void Update()
    {
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}