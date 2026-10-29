using UnityEngine;

public class Cakemix : MonoBehaviour
{
    public Maderecipes maderecipes;
    public INVENTORY inventory;

    private void OnMouseDown()
    {
        if (inventory.ladyfingers_count >= 5 && inventory.fruitjuice_count >= 1 && inventory.eggs_count >= 3 &&
            inventory.sugar_count >= 1 && inventory.milk_count >= 1 && inventory.whippedcream_count >= 1 &&
            inventory.fruits_count >= 2)
        {
            inventory.ladyfingers_count -= 5;
            inventory.eggs_count -= 3;
            inventory.sugar_count -= 1;
            inventory.whippedcream_count -= 1;
            inventory.fruitjuice_count -= 1;
            inventory.milk_count -= 1;
            inventory.fruits_count -= 2;

            maderecipes.Cake++;
            Debug.Log("Great job! You've just made a cake!");
        }
        else
        {
            Debug.Log("Buy more ingredients for a cake!");
        }
    }
}
