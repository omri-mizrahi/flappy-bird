using UnityEngine;

public class GameOver : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("GameOver")) {
            // TODO: send event of game over OR call function gameover of GameController Class
            GameController.EndGame();
        }
    }
}
