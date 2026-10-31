using UnityEngine;

public class FRUITS_BUY : MonoBehaviour
{
    public CoinCounter coinCounter;
    public INVENTORY iNVENTORY;
    
    public AudioSource audioSource;
    public AudioClip Coins;
    
    public void BuyFruits()
    {
        if (coinCounter.totalCoins >= 10)
        {
            coinCounter.ChangeCoins(-10);
            
            audioSource.PlayOneShot(Coins);
            
            iNVENTORY.fruits_count+=1;
            Debug.Log("Fruits bought!");
        }
        else
        { 
            Debug.Log("Not enough coins!");
        }
    }
}
