using UnityEngine;

public class InvaderMovement : MonoBehaviour
{
    public float speed = 2.5f;
    private bool movingRight = true;
    public float downwardStep = 0.4f;
    public GameObject laserPrefab;

    public float minShootingRate = 1.5f; // Minimum time between shots
    public float maxShootingRate = 3.0f; // Maximum time between shots
    private float shootCooldown;
    private void ResetShootCooldown()
{
    // Set shootCooldown to a random value between minShootingRate and maxShootingRate
    shootCooldown = Random.Range(minShootingRate, maxShootingRate);
}

void Start()
    {
        ResetShootCooldown(); // Initialize shootCooldown when the game starts
    }

void Update()
    {
        if (movingRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        if (transform.position.x >= 10.0f) // Boundary Right
        {
            movingRight = false;
            transform.Translate(Vector2.down * downwardStep);
        }
        else if (transform.position.x <= -10.0f) // Boundary Left
        {
            movingRight = true;
            transform.Translate(Vector2.down * downwardStep);
        }

         {

        if (shootCooldown > 0)
        {
            shootCooldown -= Time.deltaTime;
        }
        else
        {
            Shoot();
           ResetShootCooldown(); // Reset cooldown after shooting
        }
    }

void ResetShootCooldown()
    {
        shootCooldown = Random.Range(minShootingRate, maxShootingRate); // Set to a random value within range
    }

    }
void Shoot()
    {
        // Instantiate the laser
        if (laserPrefab != null)
        {
            Vector3 startPosition = transform.position; // Start position right below the invader
            startPosition.y -= 0.5f;
            Instantiate(laserPrefab, startPosition, Quaternion.identity);
        }
    }
}
