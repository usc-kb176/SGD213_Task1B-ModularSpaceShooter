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
        movement = GetComponent<MovementScript>();
        movement.RigidbodySetup();
    }

    void Update()
    {
        movement.MovePlayer(acceleration, movementDirection);
    }
}
