using UnityEngine;

public class MovementBullet : MonoBehaviour
{
    private float acceleration = 50f;
    private float initialVelocity = 5f;
    private Vector2 movementDirection = Vector2.up;

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