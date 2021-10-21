using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour
{
    public Rigidbody rb;
    public float force = 50f;
    public int jumpCount = 2;

    void Update()
    {


        if (Input.GetKeyDown("space"))
        {
            if (jumpCount == 2)
            {
                rb.velocity = new Vector3(rb.velocity.x, 5.2f, rb.velocity.z);
                --jumpCount;
            }
            else
            {
                if (jumpCount == 1)
                {
                    rb.velocity = new Vector3(rb.velocity.x, 5.2f, rb.velocity.z);
                    --jumpCount;
                    StartCoroutine(Wait());
                }
            }
        }

        IEnumerator Wait()
        {
            yield return new WaitForSeconds(1f);
            jumpCount = 2;
        }
    }

    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, force * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -force * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
