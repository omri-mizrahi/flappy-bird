using UnityEngine;

public class MoveObstacle : MonoBehaviour
{
    #region Variables
    public float speed = 15f;
    SpriteRenderer rndr;
    #endregion
    #region UnityMethods

    void Start() {
        rndr = GetComponent<SpriteRenderer>();
    }
    
    void Update() {
        if(transform.position.x < -6f) {
            Destroy(gameObject);
        }
    }

    void FixedUpdate() {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }

    #endregion
}
