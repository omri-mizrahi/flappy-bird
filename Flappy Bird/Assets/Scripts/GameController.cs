using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameController : MonoBehaviour
{
    #region Variables
    const string PregameGameMode = "pregame";
    const string PlayingGameMode = "playing";
    const string GameoverGameMode = "gameover";


    public GameObject startMessage;
    public GameObject gameoverMessage;
    public GameObject obstacles;
    public Rigidbody2D playerRb;
    private ObstaclesManager obstaclesManager;
    private string currGameMode = PregameGameMode;
    #endregion

    void Start() {
        obstaclesManager = obstacles.GetComponent<ObstaclesManager>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump")) {
            switch (currGameMode) {
                case PregameGameMode:
                    StartGame();
                    break;
                case GameoverGameMode:
                    ResetGame();
                    break;
            }
        }
    }

    void StartGame() {
        startMessage.SetActive(false);
        obstacles.SetActive(true);
        playerRb.isKinematic = false;
        currGameMode = PlayingGameMode;
    }

    public void EndGame() {
        obstaclesManager.StopObstacles();
        gameoverMessage.SetActive(true);
        StartCoroutine(gameoverModeAfterTime(1));
    }

    IEnumerator gameoverModeAfterTime(float seconds) {
        yield return new WaitForSeconds(seconds);
        currGameMode = GameoverGameMode;
    }

    void ResetGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
