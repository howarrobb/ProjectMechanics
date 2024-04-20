using UnityEngine;

public class GameController : MonoBehaviour
{
    public InvaderManager invaderManager;
    public TetrisManager tetrisManager;  // This line should be inside your class but outside any methods

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) // Press 1 to spawn invaders
        {
            invaderManager.TriggerInvaderSpawn();        
            }
        if (Input.GetKeyDown(KeyCode.Alpha2)) // Press 2 to trigger Tetris block spawn
        {
            tetrisManager.StartSpawning(); // Assuming this method exists in TetrisManager
        }

    }
}
