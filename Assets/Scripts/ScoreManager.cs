using UnityEngine;
using TMPro; // נדרש עבור TextMeshPro

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance; // משתנה סטטי לגישה ל-ScoreManager

    public int score = 0; // משתנה לניקוד
    public TMP_Text scoreText; // טקסט להצגת הניקוד עם TextMeshPro

    private void Awake()
    {
        // אם אין Instance, הגדר את האובייקט הנוכחי כ-Instance
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            // השמדת אובייקטים כפולים
            Destroy(gameObject);
        }
    }

    public void AddScore()
    {
        score += 1;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }
}
