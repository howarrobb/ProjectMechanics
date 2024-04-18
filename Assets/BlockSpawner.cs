using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public GameObject[] blockPrefabs;
    public float spawnRate = 2.0f;
    private float nextTimeToSpawn = 0.0f;

    void Update()
    {
        if (Time.time >= nextTimeToSpawn)
        {
            SpawnBlock();
            nextTimeToSpawn = Time.time + 1f / spawnRate;
        }
    }

    void SpawnBlock()
    {
        int randomIndex = Random.Range(0, blockPrefabs.Length);
        Vector3 spawnPosition = new Vector3(Random.Range(-5f, 5f), transform.position.y, 0);
        Instantiate(blockPrefabs[randomIndex], spawnPosition, Quaternion.identity);
    }
}
