using UnityEngine;

public class LADY_FINGERS_BUY : MonoBehaviour
{
    public CoinCounter coinCounter;
    public INVENTORY iNVENTORY;
    
    public void BuyLadyFingers()
    {
        if (coinCounter.totalCoins >= 3)
        {
            coinCounter.ChangeCoins(-3);
            iNVENTORY.ladyfingers_count+=1;
            Debug.Log("Lady fingers bought!");
        }
        else
        { 
            Debug.Log("Not enough coins!");
        }
    }
}
