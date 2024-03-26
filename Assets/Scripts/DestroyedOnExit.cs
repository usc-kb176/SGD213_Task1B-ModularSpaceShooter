using UnityEngine;

public class DestroyedOnExit : MonoBehaviour
{
    // Destory the GameObject when it is no longer visable by the camera (Unity Function)
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
