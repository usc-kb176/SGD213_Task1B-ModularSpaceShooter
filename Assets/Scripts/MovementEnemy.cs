using UnityEngine;

public class MovementEnemy : MonoBehaviour
{
    private float acceleration = 75f;
    private float initialVelocity = 2f;
    private Vector2 movementDirection = Vector2.down;

    private MovementScript movement;

    private void Start()
    {
        // Call the functions within the movement script to setup Rigidbody & Rigidbody Velocity
        movement = GetComponent<MovementScript>();
        movement.RigidbodySetup();
        movement.RigidbodyVelocitySetup(initialVelocity, movementDirection);
    }

    private void Update()
    {
        // Call MoveObject every frame
        movement.MoveObject(acceleration, movementDirection);
    }
}