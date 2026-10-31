using UnityEngine;

public class BAKING_POWDER_BUY : MonoBehaviour
{
    public CoinCounter coinCounter;
    public INVENTORY iNVENTORY;
    
    public AudioSource audioSource;
    public AudioClip Coins;

    public void BuyBakingSoda()
    {
        if (coinCounter.totalCoins >= 2)
        {
            coinCounter.ChangeCoins(-2);
            
            audioSource.PlayOneShot(Coins);
            
            iNVENTORY.bakingsoda_count+=1;
            Debug.Log("Baking Powder bought!");
        }
        else
        { 
            Debug.Log("Not enough coins!");
        }
    }
}
