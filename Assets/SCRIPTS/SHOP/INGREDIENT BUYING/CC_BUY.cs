using NUnit.Framework.Constraints;
using UnityEngine;

public class CC_BUY : MonoBehaviour
{
    public CoinCounter coinCounter;
    public INVENTORY iNVENTORY;

    public AudioSource audioSource;
    public AudioClip Coins;
    public void BuyCC()
    {
        if (coinCounter.totalCoins >= 1)
        { 
            coinCounter.ChangeCoins(-1); 
            
            audioSource.PlayOneShot(Coins);
            
            iNVENTORY.cc_count+=1;
            Debug.Log("Chocolate Chips bought!");
        }
        else
        { 
            Debug.Log("Not enough coins!");
        }
            
    }
}
