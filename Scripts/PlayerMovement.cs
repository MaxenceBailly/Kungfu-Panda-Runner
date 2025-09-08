using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 2;
    public float horizontalSpeed = 3;
    public float rightBoundary = 5.5f;
    public float leftBoundary = -5.5f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * playerSpeed * Time.deltaTime, Space.World);

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x > leftBoundary)
            {
                transform.Translate(Vector3.left * horizontalSpeed * Time.deltaTime);
            }
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.position.x < rightBoundary)
            {
                transform.Translate(Vector3.right * horizontalSpeed * Time.deltaTime);
            }
        }
    }
}
