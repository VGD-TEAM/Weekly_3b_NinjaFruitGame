using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    
    public GameObject[] fruits; // רשימת Prefabs של פירות (בננה ותות)
    public float spawnInterval = 1f; // זמן בין יצירות פירות
    public Vector2 spawnRangeX = new Vector2(-8, 8); // הטווח האופקי של המיקום הרנדומלי

    void Start()
    {
        // התחלת מנגנון ה-Spawn
        InvokeRepeating("SpawnFruit", 0f, spawnInterval);
    }

    void SpawnFruit()
    {
        if (fruits.Length == 0)
        {
            Debug.LogError("No fruits assigned to the spawner!");
            return;
        }

        // בחר פרי רנדומלי
        int randomIndex = Random.Range(0, fruits.Length);
        GameObject fruit = fruits[randomIndex];

        // בחר מיקום רנדומלי
        float randomX = Random.Range(spawnRangeX.x, spawnRangeX.y);
        Vector3 spawnPosition = new Vector3(randomX, transform.position.y, 0);

        Debug.Log($"Spawning fruit: {fruit.name} at {spawnPosition}"); // הודעת דיבוג

        // צור את הפרי
        Instantiate(fruit, spawnPosition, Quaternion.identity);
    }
}
