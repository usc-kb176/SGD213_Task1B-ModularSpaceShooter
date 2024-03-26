using UnityEngine;

public class DestroyedOnExit : MonoBehaviour
{
    // Called when the object leaves the viewport
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
