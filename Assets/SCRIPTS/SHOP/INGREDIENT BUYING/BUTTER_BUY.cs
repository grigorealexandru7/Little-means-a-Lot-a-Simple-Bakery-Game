using UnityEngine;

public class BUTTER_BUY : MonoBehaviour
{
    public CoinCounter coinCounter;
    public INVENTORY iNVENTORY;

    public void BuyButter()
    {
        if (coinCounter.totalCoins >= 2)
        {
            coinCounter.ChangeCoins(-2);
            iNVENTORY.butter_count+=1;
            Debug.Log("Butter bought!");
        }
        else
        {
            Debug.Log("Not enough coins!");
        }
            
    }
}
