using UnityEngine;

public class LADY_FINGERS_BUY : MonoBehaviour
{
    public CoinCounter coinCounter;
    public INVENTORY iNVENTORY;
    
    public AudioSource audioSource;
    public AudioClip Coins;
    public void BuyLadyFingers()
    {
        if (coinCounter.totalCoins >= 8)
        {
            coinCounter.ChangeCoins(-8);
            
            audioSource.PlayOneShot(Coins);
            
            iNVENTORY.ladyfingers_count+=1;
            Debug.Log("Lady fingers bought!");
        }
        else
        { 
            Debug.Log("Not enough coins!");
        }
    }
}
