using UnityEngine;

public class FRUITS_BUY : MonoBehaviour
{
    public CoinCounter coinCounter;
    public INVENTORY iNVENTORY;
    
    public void BuyFruits()
    {
        if (coinCounter.totalCoins >= 10)
        {
            coinCounter.ChangeCoins(-10);
            iNVENTORY.fruits_count+=1;
            Debug.Log("Fruits bought!");
        }
        else
        { 
            Debug.Log("Not enough coins!");
        }
    }
}
