using UnityEngine;

public class GameController : MonoBehaviour
{
    public InvaderManager invaderManager;
    public TetrisManager tetrisManager;  // This line should be inside your class but outside any methods

    void Start()
    {
        //Start the invader spawn after 2 seconds
        Invoke(nameof(StartInvaders), 2f);

        //Start spawning Tetris blocks after 10 seconds
        Invoke(nameof(StartTetris), 10f);
    }

        void StartInvaders()
        {
            invaderManager.TriggerInvaderSpawn();
        }

        void StartTetris()
        {
            tetrisManager.StartSpawning();
        }
}