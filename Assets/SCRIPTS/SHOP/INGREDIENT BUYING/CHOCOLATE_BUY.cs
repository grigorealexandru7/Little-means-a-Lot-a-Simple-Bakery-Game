using UnityEngine;

public class CHOCOLATE_BUY : MonoBehaviour
{
    public CoinCounter coinCounter;
    public INVENTORY iNVENTORY;
    
    public void BuyChocolate()
    {
        if (coinCounter.totalCoins >= 3)
        {
            coinCounter.ChangeCoins(-3);
            iNVENTORY.chocolate_count+=1;
            Debug.Log("Chocolate bought!");
        }
        else
        { 
            Debug.Log("Not enough coins!");
        }
    }
}
