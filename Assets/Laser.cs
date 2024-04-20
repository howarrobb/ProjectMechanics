using UnityEngine;

public class Laser : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime); // Moves downward

        if (transform.position.y < -10f) // Assuming -10 is below your screen
        {
            Destroy(gameObject); // Destroy the laser when it's off-screen
        }
    }
}
