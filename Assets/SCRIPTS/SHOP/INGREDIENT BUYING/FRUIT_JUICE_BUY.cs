using UnityEngine;

public class FRUIT_JUICE_BUY : MonoBehaviour
{
    public CoinCounter coinCounter;
    public INVENTORY iNVENTORY;
    
    public void BuyFruitJuice()
    {
        if (coinCounter.totalCoins >= 5)
        {
            coinCounter.ChangeCoins(-5);
            iNVENTORY.fruitjuice_count+=1;
            Debug.Log("Fruit juice bought!");
        }
        else
        { 
            Debug.Log("Not enough coins!");
        }
    }
}
