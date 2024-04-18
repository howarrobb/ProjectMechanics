using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f;  // Speed at which the player moves
    public GameObject bulletPrefab;
    public Transform shootingOffset;
    public float shootingRate = 1.0f;
    private float shootingCooldown;

    private Rigidbody2D rb;  // Reference to the Rigidbody2D component
    private Vector2 movement;  // The vector to store the direction of movement

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  // Get the Rigidbody2D component from the player GameObject
    }

    void Update()
    {
        // Input.GetAxisRaw returns a value of -1, 0, or 1 for left/right or up/down arrow keys (or WASD keys)
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (Input.GetKey(KeyCode.Space) && shootingCooldown <= 0)
        {
            Shoot();
            shootingCooldown = shootingRate;
        }
        if (shootingCooldown > 0)
        {
            shootingCooldown -= Time.deltaTime;
        }
    }

    void Shoot()
    {
        if (bulletPrefab && shootingOffset)
        {
            Instantiate(bulletPrefab, shootingOffset.position, Quaternion.identity);
        }
    }

    

    void FixedUpdate()
    {
        // Move the player by setting the velocity of the Rigidbody2D
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
