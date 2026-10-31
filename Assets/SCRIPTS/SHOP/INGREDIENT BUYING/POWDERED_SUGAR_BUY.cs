using UnityEngine;

public class POWDERED_SUGAR_BUY : MonoBehaviour
{
    public CoinCounter coinCounter;
    public INVENTORY iNVENTORY;
    
    public AudioSource audioSource;
    public AudioClip Coins;
    public void BuyPowderedSugar()
    {
        if (coinCounter.totalCoins >= 4)
        {
            coinCounter.ChangeCoins(-4);
            
            audioSource.PlayOneShot(Coins);
            
            iNVENTORY.powdersugar_count+=1;
            Debug.Log("Powdered sugar bought!");
        }
        else
        { 
            Debug.Log("Not enough coins!");
        }
    }
}
