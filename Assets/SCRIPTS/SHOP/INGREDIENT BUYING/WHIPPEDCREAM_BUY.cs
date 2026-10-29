using UnityEngine;

public class WHIPPEDCREAM_BUY : MonoBehaviour
{
    public CoinCounter coinCounter;
    public INVENTORY iNVENTORY;
    
    public void BuyWhippedCream()
    {
        if (coinCounter.totalCoins >= 4)
        {
            coinCounter.ChangeCoins(-4);
            iNVENTORY.whippedcream_count+=1;
            Debug.Log("Whipped cream bought!");
        }
        else
        { 
            Debug.Log("Not enough coins!");
        }
    }
}
