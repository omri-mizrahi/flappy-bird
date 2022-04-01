using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameController gameController;

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("GameOver")) {
            gameController.EndGame();
        }
    }
    // TODO: change collider of obstacles to trigger, add here an OnTriggerEnter to check if game over
}
