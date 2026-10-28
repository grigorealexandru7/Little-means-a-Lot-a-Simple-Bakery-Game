using UnityEngine;

public class COCOA_BUY : MonoBehaviour
{
    public CoinCounter coinCounter;
    public INVENTORY iNVENTORY;
    
    public void BuyCocoa()
    {
        if (coinCounter.totalCoins >= 1)
        {
            coinCounter.ChangeCoins(-1);
            iNVENTORY.cocoa_count+=1;
            Debug.Log("Cocoa bought!");
        }
        else
        { 
            Debug.Log("Not enough coins!");
        }
    }
}
