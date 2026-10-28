using UnityEngine;

public class SPRINKLES_BUY : MonoBehaviour
{
    public CoinCounter coinCounter;
    public INVENTORY iNVENTORY;
    
    public void BuySprinkles()
    {
        if (coinCounter.totalCoins >= 1)
        {
            coinCounter.ChangeCoins(-1);
            iNVENTORY.sprinkles_count+=1;
            Debug.Log("Sprinkles bought!");
        }
        else
        { 
            Debug.Log("Not enough coins!");
        }
    }
}
