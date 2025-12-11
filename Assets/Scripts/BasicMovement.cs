using System.Runtime.InteropServices;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody2D rb;

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        rb.linearVelocity= new Vector2(horizontal, vertical) * speed;
    }
}
