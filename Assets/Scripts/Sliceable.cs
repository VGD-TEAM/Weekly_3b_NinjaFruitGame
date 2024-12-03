using UnityEngine;

public class Sliceable : MonoBehaviour
{
    public GameObject slicedPrefab; // Prefab של הירק החתוך
    public int scoreValue = 1; // כמות הנקודות שיתווספו ל-SCORE

    public void Slice()
    {
        // צור את הירק החתוך
        if (slicedPrefab != null)
        {
            Instantiate(slicedPrefab, transform.position, transform.rotation);
        }

        // עדכן את ה-SCORE
        ScoreManager.instance.AddScore();

        // השמד את האובייקט המקורי
        Destroy(gameObject);
    }

    private void OnMouseDown() // חיתוך בלחיצה בעכבר
    {
        Slice();
    }
}
