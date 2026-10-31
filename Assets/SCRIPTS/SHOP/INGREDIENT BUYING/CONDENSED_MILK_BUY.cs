using UnityEngine;

public class CONDENSED_MILK_BUY : MonoBehaviour
{
    public CoinCounter coinCounter;
    public INVENTORY iNVENTORY;
    
    public AudioSource audioSource;
    public AudioClip Coins;
    public void BuyCondensedMilk()
    {
        if (coinCounter.totalCoins >= 7)
        {
            coinCounter.ChangeCoins(-7);
            
            audioSource.PlayOneShot(Coins);
            
            iNVENTORY.condensedmilk_count+=1;
            Debug.Log("Condensed milk bought!");
        }
        else
        { 
            Debug.Log("Not enough coins!");
        }
    }
}
