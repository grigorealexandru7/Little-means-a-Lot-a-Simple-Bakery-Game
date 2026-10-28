using UnityEngine;
using TMPro;
public class CoinCounter : MonoBehaviour
{
    public int totalCoins;
    public TMP_Text TEXT_COINMANAGER;

    void Start()
    {
        TEXT_COINMANAGER.text = totalCoins.ToString();
        
    }
    public void ChangeCoins(int amount)
    {
        totalCoins += amount;
        TEXT_COINMANAGER.text = totalCoins.ToString();
    }
    
}
