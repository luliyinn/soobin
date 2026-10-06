using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "soobin")
        {
            collision.gameObject.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "soobin")
        {
            collision.gameObject.transform.SetParent(null);
        }
    }
}

