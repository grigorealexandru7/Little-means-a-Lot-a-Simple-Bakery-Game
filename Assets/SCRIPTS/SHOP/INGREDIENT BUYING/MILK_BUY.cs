using UnityEngine;

public class MILK_BUY : MonoBehaviour
{
    public CoinCounter coinCounter;
    public INVENTORY iNVENTORY;
    
    public void BuyMilk()
    {
        if (coinCounter.totalCoins >= 5)
        {
            coinCounter.ChangeCoins(-5);
            iNVENTORY.milk_count+=1;
            Debug.Log("Milk bought!");
        }
        else
        { 
            Debug.Log("Not enough coins!");
        }
    }
}
