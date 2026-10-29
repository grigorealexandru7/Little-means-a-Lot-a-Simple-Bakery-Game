using UnityEngine;

public class CINNAMON_BUY : MonoBehaviour
{
    public CoinCounter coinCounter;
    public INVENTORY iNVENTORY;
    
    public void BuyCinnamon()
    {
        if (coinCounter.totalCoins >= 5)
        {
            coinCounter.ChangeCoins(-5);
            iNVENTORY.cinnamon_count+=1;
            Debug.Log("Cinnamon bought!");
        }
        else
        { 
            Debug.Log("Not enough coins!");
        }
    }
}
