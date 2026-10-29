using UnityEngine;

public class Tartmix : MonoBehaviour
{
    public Maderecipes maderecipes;
    public INVENTORY inventory;

    private void OnMouseDown()
    {
        if (inventory.flour_count >= 1 && inventory.butter_count >= 2 && inventory.sugar_count >= 2 &&
            inventory.eggs_count >= 2 && inventory.milk_count >= 1 && inventory.cornstarch_count >= 1 &&
            inventory.fruits_count >= 1)
        {
            inventory.flour_count -= 1;
            inventory.butter_count -= 2;
            inventory.sugar_count -= 2;
            inventory.eggs_count -= 2;
            inventory.milk_count -= 1;
            inventory.cornstarch_count -= 1;
            inventory.fruits_count -= 1;

            maderecipes.Tart++;
            Debug.Log("Great job! You've just made a tart!");
        }
        else
        {
            Debug.Log("Buy more ingredients for a tart!");
        }
    }
}
