using UnityEngine;

public class CORN_STARCH_BUY : MonoBehaviour
{
    public CoinCounter coinCounter;
    public INVENTORY iNVENTORY;
    
    public void BuyCornStarch()
    {
        if (coinCounter.totalCoins >= 6)
        {
            coinCounter.ChangeCoins(-6);
            iNVENTORY.cornstarch_count+=1;
            Debug.Log("Corn starch bought!");
        }
        else
        { 
            Debug.Log("Not enough coins!");
        }
    }
}
