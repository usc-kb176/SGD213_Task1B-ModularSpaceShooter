using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private float acceleration = 75f;
    private float initialVelocity = 2f;
    private Vector2 movementDirection = Vector2.down;

    public MovementScript movement;

    private void Start()
    {
        movement = GetComponent<MovementScript>();
        movement.RigidbodySetup(initialVelocity, movementDirection);
    }

    private void Update()
    {
        movement.MoveObject(acceleration, movementDirection);
    }
}