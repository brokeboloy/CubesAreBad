using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{
    private Rigidbody cubeRb;
    private GameManager gameManager;

    private float torqueForce = 20f;


    private void Awake()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();      
    }

    // Start is called before the first frame update
    void Start()
    {
        cubeRb = GetComponent<Rigidbody>();
        cubeRb.AddTorque(Random.Range(torqueForce, -torqueForce), Random.Range(torqueForce, -torqueForce), Random.Range(torqueForce, -torqueForce), ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameManager.gameOver = true;
            Debug.Log("Game Over");
        }
    }
}
