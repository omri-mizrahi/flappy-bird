using UnityEngine;

public class GameOver : MonoBehaviour
{
    #region Variables
    public GameController gameController;
    #endregion
    
    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("GameOver")) {
            gameController.EndGame();
        }
    }
}
