using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    private float acceleration = 50f;
    private float initialVelocity = 5f;
    private Vector2 movementDirection = Vector2.up;

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