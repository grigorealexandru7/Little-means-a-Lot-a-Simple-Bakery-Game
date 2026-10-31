using UnityEngine;

public class FRUIT_JUICE_BUY : MonoBehaviour
{
    public CoinCounter coinCounter;
    public INVENTORY iNVENTORY;
    
    public AudioSource audioSource;
    public AudioClip Coins;
    public void BuyFruitJuice()
    {
        if (coinCounter.totalCoins >= 9)
        {
            coinCounter.ChangeCoins(-9);
            
            audioSource.PlayOneShot(Coins);
            
            iNVENTORY.fruitjuice_count+=1;
            Debug.Log("Fruit juice bought!");
        }
        else
        { 
            Debug.Log("Not enough coins!");
        }
    }
}
