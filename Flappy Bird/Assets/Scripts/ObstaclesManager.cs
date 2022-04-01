using UnityEngine;

public class ObstaclesManager : MonoBehaviour
{
    #region Variables
    public GameObject obstacle;
    const float spawnXPos = 6f;
    const float maxYPos = 0.5f;
    const float minYPos = -3.2f;
    public float spawnRateSeconds = 1.25f;
    #endregion

    void Start() {
        InvokeRepeating(nameof(SpawnObstacle), 0, spawnRateSeconds);
    }

    private void SpawnObstacle() {
        float spawnYPos = Random.Range(minYPos, maxYPos);
        Instantiate(obstacle, new Vector3(spawnXPos, spawnYPos, 0), Quaternion.identity, transform);
    }

    public void StopObstacles() {
        CancelInvoke();
        var moverComponents = gameObject.GetComponentsInChildren<MoveObstacle>();
        foreach (MoveObstacle component in moverComponents) {
            component.enabled = false;
        }
    }

    /* TODO: To make the obstacles system more efficient, I can use the same 3 obstacles over and over again, no need for spawner and destroyer. 
    1. Start the scene with 3 obstacles out of the screen at different heights and same distance between them (in the editor).
    2. Change the destroyer script of SceneLeftBorder - teleport collided obstacles to the spawn point and randomize the height.

    * A small problem: the first 3 obstacles will be at the same heights every round. */
}
