using UnityEngine;

public class BUTTER_BUY : MonoBehaviour
{
    public CoinCounter coinCounter;
    public INVENTORY iNVENTORY;

    public AudioSource audioSource;
    public AudioClip Coins;
    public void BuyButter()
    {
        if (coinCounter.totalCoins >= 2)
        {
            coinCounter.ChangeCoins(-2);
            
            audioSource.PlayOneShot(Coins);
            
            iNVENTORY.butter_count+=1;
            Debug.Log("Butter bought!");
        }
        else
        {
            Debug.Log("Not enough coins!");
        }
            
    }
}
