using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;

    public float horizontalInput;
    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        playerRb.velocity = new Vector3(horizontalInput * speed , 0, 0);
    }


}
