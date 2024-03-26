using UnityEngine;

public class MovementScript : MonoBehaviour
{
    private Rigidbody2D rb;

    /// <summary>
    /// RigidbodySetup() - Setup a Rigidbody2D with velocity using a 
    /// direction (up, down, left, right) and an initial velocity.
    /// </summary>
    /// <param name="direction">Vector2.direction (up, down, left, right)</param>
    /// <param name="initialVelocity">float</param>
    public void RigidbodySetup(float initialVelocity, Vector2 direction)
    {
        rb = GetComponent<Rigidbody2D>();
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
}