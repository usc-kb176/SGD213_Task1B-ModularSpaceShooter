using UnityEngine;

public class ShootingScript : MonoBehaviour
{

    [SerializeField]
    private GameObject bullet;

    [SerializeField]
    private float fireDelay = 1f;

    private float lastFiredTime = 0f;
    private float bulletOffset = 2f;

    /// <summary>
    /// SetupBulletOffset() - Setup the offset of the bullet so it doesn't spawn
    /// ontop of the spaceship
    /// </summary>
    public void SetupBulletOffset()
    {
        // Do some math to perfectly spawn bullets in front of us
        bulletOffset = GetComponent<Renderer>().bounds.size.y / 2 // Half of our size
            + bullet.GetComponent<Renderer>().bounds.size.y / 2; // Plus half of the bullet size
    }

    /// <summary>
    /// ShootBullet() - Fire a bullet when the user presses the fire button
    /// </summary>
    public void ShootBullet()
    {
        if (Input.GetButton("Fire1"))
        {
            float currentTime = Time.time;

            // Have a delay so we don't shoot too many bullets
            if (currentTime - lastFiredTime > fireDelay)
            {
                Vector2 spawnPosition = new Vector2(transform.position.x, transform.position.y + bulletOffset);
                Instantiate(bullet, spawnPosition, transform.rotation);
                lastFiredTime = currentTime;
            }
        }
    }


}
