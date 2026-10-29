using UnityEngine;

public class EGGS_BUY : MonoBehaviour
{
    public CoinCounter coinCounter;
    public INVENTORY iNVENTORY;

    public void BuyEggs()
    {
        if (coinCounter.totalCoins >= 4)
        {
            coinCounter.ChangeCoins(-4);
            iNVENTORY.eggs_count+=1;
            Debug.Log("Eggs bought!");
        }
        else
        { 
            Debug.Log("Not enough coins!");
        }
    }
}
