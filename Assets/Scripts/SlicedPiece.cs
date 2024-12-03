using UnityEngine;

public class SlicedPiece : MonoBehaviour
{

    public Vector2 forceDirection;

    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.AddForce(forceDirection, ForceMode2D.Impulse);
        }
    }
}
