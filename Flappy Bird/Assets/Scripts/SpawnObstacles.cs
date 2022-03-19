using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    #region Variables
    public GameObject obstacle;
    float spawnXPos = 6f;
    float maxYPos = -0.3f;
    float minYPos = -4.5f;
    public float spawnRateSeconds = 2f;
    #endregion

    #region UnityMethods

    void Start() {
        InvokeRepeating(nameof(SpawnObstacle), 0, spawnRateSeconds);
    }

    private void SpawnObstacle() {
        float spawnYPos = Random.Range(minYPos, maxYPos);
        Instantiate(obstacle, new Vector3(spawnXPos, spawnYPos, -1), obstacle.transform.rotation, transform).SetActive(true);
    }

    #endregion
}
