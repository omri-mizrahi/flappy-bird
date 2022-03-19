using UnityEngine;

public class MoveObstacle : MonoBehaviour
{
    #region Variables
    public float speed = 15f;
    #endregion
    #region UnityMethods


    void Update() {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }

    #endregion
}
