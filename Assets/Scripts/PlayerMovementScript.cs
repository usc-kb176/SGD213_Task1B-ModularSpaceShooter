using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    // SerializeField exposes this value to the Editor, but not to other Scripts!
    // It is "pseudo public"
    // HorizontalPlayerAcceleration indicates how fast we accelerate Horizontally
    [SerializeField]
    private float acceleration = 5000f;

    private Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        // Get OurRigidbodyComponent once at the start of the game and store a reference to it
        // This means that we don't need to call GetComponent more than once! This makes our game faster. (GetComponent is SLOW)
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        if (horizontalInput != 0.0f)
        {
            Vector2 ForceToAdd = Vector2.right * horizontalInput * acceleration * Time.deltaTime;
            rb.AddForce(ForceToAdd);
            //print(HorizontalInput);
        }
    }

}
