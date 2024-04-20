using UnityEngine;

public class TetrisBlockController : MonoBehaviour
{
    public GameObject player; // Reference to the player GameObject
    public float stepTime = 0.9f; // Time interval between steps
    private Rigidbody2D rb;
    private float timeSinceLastStep = 0f;
    private bool canMoveHorizontally = true; //Flag to control horizontal movement

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if (player == null)
        {
            player = GameObject.FindWithTag("Player"); // Ensure the player has a tag "Player"
        }
    }

    private void Update()
    {
        if (timeSinceLastStep >= stepTime)
        {
            if (canMoveHorizontally)
            StepTowardsPlayer();
            timeSinceLastStep = 0f;
        }
        else
        {
            timeSinceLastStep += Time.deltaTime;
        }
    }

    void StepTowardsPlayer()
    {
        if (player != null)
        {
            float stepSize = 1.0f; // Define how big each step should be
            float direction = Mathf.Sign(player.transform.position.x - transform.position.x);
            // Calculate the new position
            float newPositionX = transform.position.x + stepSize * direction;
            // Move the block horizontally by setting the Rigidbody2D position
            rb.MovePosition(new Vector2(newPositionX, transform.position.y));

            // Optionally, clamp to ensure no overshoot
            if (Mathf.Abs(transform.position.x - player.transform.position.x) < stepSize)
            {
                rb.MovePosition(new Vector2(player.transform.position.x, transform.position.y));
            }
        }
    }
            private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision is with the ground
            if (collision.gameObject.CompareTag("BottomBoundary"))
        {
            canMoveHorizontally = false;  // Stop horizontal movement
            rb.velocity = Vector2.zero;  // Stop all movement
            rb.isKinematic = true;  // Makes the block unaffected by physics
        }
    }

}
