using System;
using UnityEngine;

public class Cookiemix : MonoBehaviour
{
    public Maderecipes maderecipes;
    public INVENTORY inventory;

    private void OnMouseDown()
    {
        if (inventory.flour_count >= 1 && inventory.butter_count >= 1 && inventory.sugar_count >= 1 &&
            inventory.eggs_count >= 1 && inventory.cc_count >= 1 && inventory.bakingsoda_count >= 1)
        {
            inventory.flour_count -= 1;
            inventory.butter_count -= 1;
            inventory.sugar_count -= 1;
            inventory.eggs_count -= 1;
            inventory.cc_count -= 1;
            inventory.bakingsoda_count -= 1;
            
            maderecipes.Cookie++;
            Debug.Log("Great job! You've just made a cookie!");
        }
        else
        {
            Debug.Log("Buy more ingredients for a cookie!");
        }
    }
}
