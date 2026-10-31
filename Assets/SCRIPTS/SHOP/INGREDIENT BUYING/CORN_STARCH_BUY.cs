using UnityEngine;

public class CORN_STARCH_BUY : MonoBehaviour
{
    public CoinCounter coinCounter;
    public INVENTORY iNVENTORY;
    
    public AudioSource audioSource;
    public AudioClip Coins;
    public void BuyCornStarch()
    {
        if (coinCounter.totalCoins >= 6)
        {
            coinCounter.ChangeCoins(-6);
            
            audioSource.PlayOneShot(Coins);
            
            iNVENTORY.cornstarch_count+=1;
            Debug.Log("Corn starch bought!");
        }
        else
        { 
            Debug.Log("Not enough coins!");
        }
    }
}
