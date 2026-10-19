using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // Who touched me? Do they have PlayerCoins?
        PlayerCoins wallet = other.GetComponent<PlayerCoins>();

        if (wallet != null)
        {
            wallet.AddCoin();
            Destroy(gameObject);
        }
    }
}
