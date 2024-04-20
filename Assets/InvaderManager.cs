using UnityEngine;

public class InvaderManager : MonoBehaviour
{
      public InvaderGridSpawner invaderSpawner;

    public void TriggerInvaderSpawn()
    {
        invaderSpawner.StartSpawning();
    }
}
