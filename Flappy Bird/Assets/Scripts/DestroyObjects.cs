using UnityEngine;

public class DestroyObjects : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider) {
        Destroy(collider.gameObject);
    }
}
