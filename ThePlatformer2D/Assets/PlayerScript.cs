using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    float xMove;
    float yMove;

    float movementSpeed = 10;

    void Update()
    {
        movement();
    }

    void movement()
    {
        xMove = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;
        yMove = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;

        transform.position += new Vector3(xMove, yMove, 0);
    }
}
