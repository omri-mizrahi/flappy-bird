using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public static int scoreValue = 0;
    TextMeshProUGUI scoreText;
    
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
