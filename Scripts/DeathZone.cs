using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        
    }

    // Object collides with another object
    private void OnCollisionEnter(Collision other)
    {
        // Ignore non-player collisions
        if (other.gameObject.tag != "Player") return;

        // Reset player position
        other.gameObject.transform.position = new Vector3(0, 1.1f, -95);
    }
}
