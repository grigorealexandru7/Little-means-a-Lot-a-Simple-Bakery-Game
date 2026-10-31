using UnityEngine;

public class FLOUR_BUY : MonoBehaviour
{
    public CoinCounter coinCounter;
    public INVENTORY iNVENTORY;
    
    public AudioSource audioSource;
    public AudioClip Coins;
    
    public void BuyFlour()
    {
        if (coinCounter.totalCoins >= 0)
        {
            coinCounter.ChangeCoins(-0);
            
            audioSource.PlayOneShot(Coins);
            
            iNVENTORY.flour_count+=1;
            Debug.Log("Flour bought!");
        }
        else
        {
            Debug.Log("Not enough coins!");
        }
    }
    
}
