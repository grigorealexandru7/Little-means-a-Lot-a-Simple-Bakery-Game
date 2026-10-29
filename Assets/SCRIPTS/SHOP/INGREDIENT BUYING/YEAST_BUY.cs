using UnityEngine;

public class YEAST_BUY : MonoBehaviour
{
    public CoinCounter coinCounter;
    public INVENTORY iNVENTORY;

    public void BuyYeast()
    {
        if (coinCounter.totalCoins >= 0)
        { 
            coinCounter.ChangeCoins(-0); 
            iNVENTORY.yeast_count+=1;
            Debug.Log("Yeast bought!");
        }
        else
        { 
            Debug.Log("Not enough coins!");
        }
            
    }
}
