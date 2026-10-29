using UnityEngine;

public class SPRINKLES_BUY : MonoBehaviour
{
    public CoinCounter coinCounter;
    public INVENTORY iNVENTORY;
    
    public void BuySprinkles()
    {
        if (coinCounter.totalCoins >= 3)
        {
            coinCounter.ChangeCoins(-3);
            iNVENTORY.sprinkles_count+=1;
            Debug.Log("Sprinkles bought!");
        }
        else
        { 
            Debug.Log("Not enough coins!");
        }
    }
}
