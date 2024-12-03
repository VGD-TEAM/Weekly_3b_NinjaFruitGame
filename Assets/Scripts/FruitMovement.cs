using UnityEngine;

public class FruitMovement : MonoBehaviour
{
    public float speed = 0.1f;

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        // השמדת פרי אם הוא יוצא מהמסך
        if (transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }
}
