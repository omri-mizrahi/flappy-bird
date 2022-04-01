using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    #region Variables
    public static int scoreValue = 0;
    TextMeshProUGUI scoreText;
    #endregion
    
    void Awake()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        scoreValue = 0;
    }

    void LateUpdate()
    {
        scoreText.text = scoreValue.ToString();
    }
}
