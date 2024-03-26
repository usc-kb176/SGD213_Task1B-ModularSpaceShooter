using UnityEngine;

public class MovementEnemy : MonoBehaviour
{
    private float acceleration = 75f;
    private float initialVelocity = 2f;
    private Vector2 movementDirection = Vector2.down;

    private MovementScript movement;

    private void Start()
    {
        movement = GetComponent<MovementScript>();
        movement.RigidbodySetup();
        movement.RigidbodyVelocitySetup(initialVelocity, movementDirection);
    }

    private void Update()
    {
        movement.MoveObject(acceleration, movementDirection);
    }
}