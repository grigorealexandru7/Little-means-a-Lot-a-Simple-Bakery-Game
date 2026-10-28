using UnityEngine;

public class CC_BUY : MonoBehaviour
{
    public CoinCounter coinCounter;
    public INVENTORY iNVENTORY;

    public void BuyCC()
    {
        if (coinCounter.totalCoins >= 1)
        { 
            coinCounter.ChangeCoins(-1); 
            iNVENTORY.cc_count+=1;
            Debug.Log("Chocolate Chips bought!");
        }
        else
        { 
            Debug.Log("Not enough coins!");
        }
            
    }
}
