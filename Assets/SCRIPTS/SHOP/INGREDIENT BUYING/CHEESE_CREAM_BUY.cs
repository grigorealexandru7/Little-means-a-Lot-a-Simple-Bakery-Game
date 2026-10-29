using UnityEngine;

public class CHEESE_CREAM_BUY : MonoBehaviour
{
    public CoinCounter coinCounter;
    public INVENTORY iNVENTORY;
    
    public void BuyCheeseCream()
    {
        if (coinCounter.totalCoins >= 6)
        {
            coinCounter.ChangeCoins(-6);
            iNVENTORY.creamcheese_count+=1;
            Debug.Log("Cheese Cream bought!");
        }
        else
        { 
            Debug.Log("Not enough coins!");
        }
    }
}
