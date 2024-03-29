using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    //creating public variables add them to unity's UI -Wyatt

    public float speed =.01f;
    public float jump = 0f;


    // Update is called once per frame
    void FixedUpdate()
    {
        float xDirection = Input.GetAxis("Horizontal");
        float yDirection = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(xDirection, yDirection*jump, 0.0f);

        transform.position += moveDirection * speed;

    }
}
