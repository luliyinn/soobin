using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour

{
    int coins = 0;
    [SerializeField] TextMeshProUGUI coinsText;
    [SerializeField] AudioSource collectSound;

    public PlayerLife playerLife;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.GetComponent<MeshRenderer>().enabled = false;
            other.gameObject.GetComponent<SphereCollider>().enabled = false;
            coins++;
            coinsText.text = "coins: " + coins;
            collectSound.Play();
        }
    }

    private void Update()
    {
        if (playerLife.dead)
        {
            coins = 0;
            coinsText.text = "coins: " + coins;
        }
    }
}
