using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    // SerializeField exposes this value to the Editor, but not to other Scripts!
    [SerializeField]
    private float acceleration = 5000f;

    private Vector2 movementDirection = Vector2.right;
    private MovementScript movement;

    void Start()
    {
        // Call the functions within the movement script via RigidbodySetup()
        movement = GetComponent<MovementScript>();
        movement.RigidbodySetup();
    }

    void Update()
    {
        // Every frame check for input and move that direction
        movement.MovePlayer(acceleration, movementDirection);
    }
}
