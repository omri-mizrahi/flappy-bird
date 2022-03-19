using System;
using UnityEngine;

public class Jump : MonoBehaviour
{
    #region Variables
    Rigidbody2D rb;
    public float jumpForce = 4f;
    public float fallGravityMultiplier = 2.5f;
    float fallGravity;
    #endregion

    #region UnityMethods

    void Awake() {
        rb = GetComponent<Rigidbody2D>();
        fallGravity = Physics2D.gravity.y * (fallGravityMultiplier - 1);
    }

    void Update() {
        if (Input.GetButtonDown("Jump")) {
            // rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            rb.velocity = Vector2.up * jumpForce;
        }
        if (rb.velocity.y <= 1) {
            rb.velocity += (fallGravity * Time.deltaTime) * Vector2.up;
        }
    }

    #endregion
}
