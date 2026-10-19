using UnityEngine;

public class PlayerCoins : MonoBehaviour
{
    public int coins = 0;

    public void AddCoin()
    {
        // I picked up a coin, so I count it
        coins = coins + 1;
        Debug.Log("Coins: " + coins);
    }
}
