using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject startMessage;
    public GameObject gameoverMessage;
    public GameObject ingameObjects;
    public Rigidbody2D playerRb;

    void Update()
    {
        if (Input.GetButtonDown("Jump")) {
            StartGame();
        }
    }

    void StartGame() {
        startMessage.SetActive(false);
        ingameObjects.SetActive(true);
        playerRb.isKinematic = false;
    }

    public static void EndGame() {
        print("end");
        // TODO: display game over message for couple seconds, then reset the scene.
    }

}
