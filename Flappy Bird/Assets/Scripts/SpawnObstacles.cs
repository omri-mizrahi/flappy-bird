using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    #region Variables
    public GameObject obstacle;
    float spawnXPos = 6f;
    float maxYPos = 0.5f;
    float minYPos = -3.2f;
    public float spawnRateSeconds = 2f;
    #endregion

    #region UnityMethods

    void Start() {
        InvokeRepeating(nameof(SpawnObstacle), 0, spawnRateSeconds);
    }

    private void SpawnObstacle() {
        float spawnYPos = Random.Range(minYPos, maxYPos);
        Instantiate(obstacle, new Vector3(spawnXPos, spawnYPos, 0), Quaternion.identity, transform);
    }

    #endregion
}
