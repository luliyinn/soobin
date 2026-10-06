using Unity.Hierarchy;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{

    [SerializeField] AudioSource deathSound;
    public bool dead = false;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy Body"))
        {
            GetComponent<MeshRenderer>().enabled = false;
            Die();
        }
    }

    private void Update()
    {
        if (transform.position.y < -5 && !dead)
        {
            Die();
        }
    }

    void Die()
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<PlayerMovement>().enabled = false;
        Invoke(nameof(reloadLevel), 1.3f);
        dead = true;
        deathSound.Play();
    }

    void reloadLevel()
    {
        transform.position = new Vector3(0.7752681f, 1.657f, -4.291635f);
        GetComponent<Rigidbody>().isKinematic = false;
        GetComponent<PlayerMovement>().enabled = true;
        GetComponent<MeshRenderer>().enabled = true;
        dead = false;
    }

}


