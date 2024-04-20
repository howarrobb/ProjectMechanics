using UnityEngine;
using System.Collections;

public class TetrisManager : MonoBehaviour
{
    public GameObject[] tetrisShapes; // Drag your Tetris block prefabs to this array in the inspector
    public Transform spawnPoint; // Set a spawn point in the Unity editor
    private Coroutine spawningCoroutine;

    public void StartSpawning()
    {
        if (spawningCoroutine == null) // Ensure not to start multiple coroutines
        {
            spawningCoroutine = StartCoroutine(SpawnBlocks());
        }
    }
    private IEnumerator SpawnBlocks()
    {while (true) // Infinite loop to keep spawning blocks
        {
            
        int index = Random.Range(0, tetrisShapes.Length);
        Instantiate(tetrisShapes[index], spawnPoint.position, Quaternion.identity);
        yield return new WaitForSeconds(4); // Wait for 4 seconds before spawning the next block
        }
    }

    public void StopSpawning()
    {
        if (spawningCoroutine != null)
        {
            StopCoroutine(spawningCoroutine);
            spawningCoroutine = null;
        }
    }

}
