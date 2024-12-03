using UnityEngine;

public class Fruit : MonoBehaviour
{
    public GameObject leftHalf;  // החצי השמאלי
    public GameObject rightHalf; // החצי הימני

    public void OnMouseDown()
    {
        Split(); // חותך את הפרי כשנוגעים בו עם העכבר
    }

    public void Split()
    {
        // יצירת חצאים
        GameObject left = Instantiate(leftHalf, transform.position, Quaternion.identity);
        GameObject right = Instantiate(rightHalf, transform.position, Quaternion.identity);

        // הוספת כוח לשני החצאים
        left.GetComponent<Rigidbody2D>().AddForce(new Vector2(-2f, 2f), ForceMode2D.Impulse);
        right.GetComponent<Rigidbody2D>().AddForce(new Vector2(2f, 2f), ForceMode2D.Impulse);

        // השמדת הפרי המקורי
        Destroy(gameObject);

        // עדכון ניקוד
        ScoreManager.instance.AddScore();
    }
}
