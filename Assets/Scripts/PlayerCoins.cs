using UnityEngine;
using TMPro;                  // NEW

public class PlayerCoins : MonoBehaviour
{
    public int coins = 0;
    public TMP_Text coinText;    // NEW

    public void AddCoin()
    {
        coins = coins + 1;
        // NEW, replaces Debug.Log: tell the player
        coinText.text = "Coins: " + coins;
    }
}
