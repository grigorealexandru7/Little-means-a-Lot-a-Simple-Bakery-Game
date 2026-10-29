using UnityEngine;

public class FLOUR_BUY : MonoBehaviour
{
    public CoinCounter coinCounter;
    public INVENTORY iNVENTORY;
    
    public void BuyFlour()
    {
        if (coinCounter.totalCoins >= 0)
        {
            coinCounter.ChangeCoins(-0);
            iNVENTORY.flour_count+=1;
            Debug.Log("Flour bought!");
        }
        else
        {
            Debug.Log("Not enough coins!");
        }
    }
}
