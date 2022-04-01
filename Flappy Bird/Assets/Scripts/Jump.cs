using UnityEngine;

public class Jump : MonoBehaviour
{
    #region Variables
    Rigidbody2D rb;
    public float jumpForce = 4f;
    public float fallGravityMultiplier = 2.5f;
    float fallGravity;
    bool _jump = false;
    #endregion

    void Awake() {
        rb = GetComponent<Rigidbody2D>();
        fallGravity = Physics2D.gravity.y * (fallGravityMultiplier - 1);
    }

    void Update() {
        if (Input.GetButtonDown("Jump")) {
            _jump = true;
        }
       
    }

    void FixedUpdate() {
        if (_jump) {
            rb.velocity = Vector2.up * jumpForce;
            _jump = false;
        }
        if (rb.velocity.y <= 1 && rb.velocity.y != 0) {
            rb.velocity += (fallGravity * Time.deltaTime) * Vector2.up;
        }
    }
}
