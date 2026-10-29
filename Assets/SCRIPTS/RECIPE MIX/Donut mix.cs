using System;
using UnityEngine;

public class Donutmix : MonoBehaviour
{
    public Maderecipes maderecipes;
    public INVENTORY inventory;

    private void OnMouseDown()
    {
        if (inventory.flour_count >= 1 && inventory.milk_count >= 2 && inventory.yeast_count >= 1 &&
            inventory.sugar_count >= 1 && inventory.butter_count >= 1 && inventory.eggs_count >= 2 &&
            inventory.oil_count >= 1 && inventory.powdersugar_count >= 1 && inventory.sprinkles_count >= 1)
        {
            inventory.flour_count -= 1;
            inventory.milk_count -= 2;
            inventory.yeast_count -= 1;
            inventory.sugar_count -= 1;
            inventory.butter_count -= 1;
            inventory.eggs_count -= 2;
            inventory.oil_count -= 1;
            inventory.powdersugar_count -= 1;
            inventory.sprinkles_count -= 1;

            maderecipes.Donut++;
            Debug.Log("Great job! You've just made a donut!");
        }
        else
        {
            Debug.Log("Buy more ingredients for a donut!");
        }
    }
}
