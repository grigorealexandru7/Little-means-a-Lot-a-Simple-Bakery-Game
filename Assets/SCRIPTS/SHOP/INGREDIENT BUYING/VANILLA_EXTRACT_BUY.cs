using UnityEngine;

public class VANILLA_EXTRACT_BUY : MonoBehaviour
{
    public CoinCounter coinCounter;
    public INVENTORY iNVENTORY;
    
    public void BuyVanillaExtract()
    {
        if (coinCounter.totalCoins >= 4)
        {
            coinCounter.ChangeCoins(-4);
            iNVENTORY.vanillaextract_count+=1;
            Debug.Log("Vanilla extract bought!");
        }
        else
        { 
            Debug.Log("Not enough coins!");
        }
    }
}
