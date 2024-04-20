using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f; // Correctly terminated
    public float topBoundary = 10f; // Adjust this value based on your camera's view or screen size


    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.gameObject.CompareTag("Enemy")) // Make sure your enemy has the tag "Enemy"
        {
            Destroy(hitInfo.gameObject);  // Destroys the enemy
            Destroy(gameObject);          // Destroys the bullet
        }
    }

    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
         // Check if the bullet has reached or exceeded the top boundary
        if (transform.position.y >= topBoundary)
        {
            Destroy(gameObject); // Destroy the bullet
        }
    }

     
}
