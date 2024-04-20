using UnityEngine;

public class GameController : MonoBehaviour
{
    public InvaderManager invaderManager;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) // Press 1 to spawn invaders
        {
            invaderManager.TriggerInvaderSpawn();        
            }
    }
}
