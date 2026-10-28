using UnityEngine;

public class CORN_STARCH_BUY : MonoBehaviour
{
    public CoinCounter coinCounter;
    public INVENTORY iNVENTORY;
    
    public void BuyCornStarch()
    {
        if (coinCounter.totalCoins >= 1)
        {
            coinCounter.ChangeCoins(-1);
            iNVENTORY.cornstarch_count+=1;
            Debug.Log("Corn starch bought!");
        }
        else
        { 
            Debug.Log("Not enough coins!");
        }
    }
}
