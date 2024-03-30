using UnityEngine;

public class ShootingPlayer : MonoBehaviour
{
    private ShootingScript shoot;

    // Start is called before the first frame update
    void Start()
    {
        // Set the bullet offset using the function from ShootingScript
        shoot = GetComponent<ShootingScript>();
        shoot.SetupBulletOffset();
    }

    // Update is called once per frame
    void Update()
    {
        shoot.ShootBullet();
    }
}
