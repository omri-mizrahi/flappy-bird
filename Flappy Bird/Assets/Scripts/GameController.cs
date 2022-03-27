using UnityEngine;

public class GameController : MonoBehaviour
{


    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump")) {
            // TODO: start the game. before that, start the scene frozen, or use a different scene.
        }
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("GameOver")) {
            // TODO: reset the scene
        }
    }
}
