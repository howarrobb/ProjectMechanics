using UnityEngine;

public class InvaderGridSpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int rows = 4;
    public int columns = 12;
    public float spacing = 0.7f;
    public float verticalOffset = 5.0f; // Adjust this value to set how high the enemies start

    public void StartSpawning()
    {
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                // Adjust spawn position by adding verticalOffset to the y-coordinate
                Vector2 spawnPosition = new Vector2(col * spacing, row * spacing + verticalOffset);
                Instantiate(enemyPrefab, spawnPosition, Quaternion.identity, transform);
            }
        }
    }
}
