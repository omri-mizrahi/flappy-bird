using UnityEngine;

public class MoveObstacle : MonoBehaviour
{
    #region Variables
    public float speed = 4f;
    #endregion

    void FixedUpdate() {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }

}
