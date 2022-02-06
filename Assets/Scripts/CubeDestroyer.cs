﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDestroyer : MonoBehaviour
{
 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cube"))
        {
            Destroy(other.gameObject);
        }
    }
}
