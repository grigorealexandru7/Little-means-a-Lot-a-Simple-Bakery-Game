using UnityEngine;

public class OIL_BUY : MonoBehaviour
{
    public CoinCounter coinCounter;
    public INVENTORY iNVENTORY;
    
    public void BuyOil()
    {
        if (coinCounter.totalCoins >= 3)
        {
            coinCounter.ChangeCoins(-3);
            iNVENTORY.oil_count+=1;
            Debug.Log("Oil bought!");
        }
        else
        { 
            Debug.Log("Not enough coins!");
        }
    }
}
