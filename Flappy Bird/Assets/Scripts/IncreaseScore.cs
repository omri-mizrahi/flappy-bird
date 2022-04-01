using UnityEngine;

public class IncreaseScore : MonoBehaviour
{   
    void OnTriggerEnter2D(Collider2D collider) {
        if (collider.CompareTag("Player")) {
            ScoreCounter.scoreValue += 1;
        }
    }
}
