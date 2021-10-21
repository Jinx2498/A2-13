using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    void Update()
    {
        // Rotation Formula
        transform.Rotate(30 * Time.deltaTime, 15 * Time.deltaTime, 45 * Time.deltaTime, Space.World);
    }

    void OnCollisionEnter(Collision other)
    {
        // Object Destroyed on Contact
        Destroy(gameObject);
    }
}
