using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardController : MonoBehaviour
{
    public float rotationSpeed = 50f;

    private float currentX = 0f;
    private float currentZ = 0f;

    void Update()
    {
        float inputX = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        float inputZ = Input.GetAxis("Vertical") * rotationSpeed * Time.deltaTime;

        currentX += inputZ;
        currentZ -= inputX;

        transform.localRotation = Quaternion.Euler(currentX, 0f, currentZ);
    }
}
