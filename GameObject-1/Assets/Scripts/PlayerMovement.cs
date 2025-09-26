using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    void Movement()
    {
        float x= Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Translate(x, 0, z);
    }
}
