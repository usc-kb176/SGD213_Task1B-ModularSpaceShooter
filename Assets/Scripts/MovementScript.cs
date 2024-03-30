using UnityEngine;

public class MovementScript : MonoBehaviour
{
    private Rigidbody2D rb;

    /// <summary>
    /// RigidbodySetup() - Setup a Rigidbody2D on a GameObject
    /// </summary>
    public void RigidbodySetup()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// RigidbodyVelocitySetup() - Setup a Rigidbody2D with velocity using a 
    /// direction (up, down, left, right) and an initial velocity.
    /// </summary>
    /// <param name="direction">Vector2.direction (up, down, left, right)</param>
    /// <param name="initialVelocity">float</param>
    public void RigidbodyVelocitySetup(float initialVelocity, Vector2 direction)
    {
        rb.velocity = direction.normalized * initialVelocity;
    }

    /// <summary>
    /// MoveObject() - Move the object in a direction using acceleration
    /// </summary>
    /// <param name="direction">Vector2.direction (up, down, left, right)</param>
    /// <param name="acceleration">float</param>

    public void MoveObject(float acceleration, Vector2 direction)
    {
        Vector2 ForceToAdd = direction.normalized * acceleration * Time.deltaTime;
        rb.AddForce(ForceToAdd);
    }

    /// <summary>
    /// MovePlayer() - If horizontal input is detected then, add force to the player in that direction
    /// </summary>
    /// <param name="acceleration">float</param>
    /// <param name="direction">Vector2.direction (up, down, left, right)</param>
    public void MovePlayer(float acceleration, Vector2 direction)
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        // Make sure there is horizontal input
        if (horizontalInput != 0.0f)
        {
            Vector2 forceToAdd = direction.normalized * horizontalInput * acceleration * Time.deltaTime;
            rb.AddForce(forceToAdd);
        }
    }
}