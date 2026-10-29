using UnityEngine;

public class SUGAR_BUY : MonoBehaviour
{
    public CoinCounter coinCounter;
    public INVENTORY iNVENTORY;

    public void BuySugar()
    {
        if (coinCounter.totalCoins >= 3)
        { 
            coinCounter.ChangeCoins(-3); 
            iNVENTORY.sugar_count+=1;
            Debug.Log("Sugar bought!");
        }
        else
        { 
            Debug.Log("Not enough coins!");
        }
            
    }
}
