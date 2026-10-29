using UnityEngine;

public class CONDENSED_MILK_BUY : MonoBehaviour
{
    public CoinCounter coinCounter;
    public INVENTORY iNVENTORY;
    
    public void BuyCondensedMilk()
    {
        if (coinCounter.totalCoins >= 7)
        {
            coinCounter.ChangeCoins(-7);
            iNVENTORY.condensedmilk_count+=1;
            Debug.Log("Condensed milk bought!");
        }
        else
        { 
            Debug.Log("Not enough coins!");
        }
    }
}
