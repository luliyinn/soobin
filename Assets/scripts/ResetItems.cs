using UnityEngine;

public class ResetItems : MonoBehaviour
{
    [SerializeField] GameObject reappearingObject;
    public PlayerLife playerLife;
    int colliderType = 0;

    private void Start()
    {
        if (gameObject.TryGetComponent<BoxCollider>(out BoxCollider boxCollider))
        {
            colliderType = 1;
        }
    }
    void Update()
    {
        if (playerLife.dead)
        {
            reappearingObject.GetComponent<MeshRenderer>().enabled = true;
            if (colliderType == 1)
            {
                reappearingObject.GetComponent<BoxCollider>().enabled = true;
            } else
            {
                reappearingObject.GetComponent<SphereCollider>().enabled = true;
            }
            
        }
    }
}
