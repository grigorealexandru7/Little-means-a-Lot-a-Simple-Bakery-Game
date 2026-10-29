using UnityEngine;

public class Browniemix : MonoBehaviour
{
    public Maderecipes maderecipes;
    public INVENTORY inventory;

    private void OnMouseDown()
    {
        if (inventory.chocolate_count >= 1 && inventory.butter_count >= 1 && inventory.sugar_count >= 1 &&
            inventory.eggs_count >= 2 && inventory.cocoa_count >= 1 && inventory.flour_count >= 1)
        {
            inventory.chocolate_count -= 1;
            inventory.butter_count -= 1;
            inventory.sugar_count -= 1;
            inventory.eggs_count -= 2;
            inventory.cocoa_count -= 1;
            inventory.flour_count -= 1;
            
            maderecipes.Brownie++;
            Debug.Log("Great job! You've just made a brownie!");
        }
        else
        {
            Debug.Log("Buy more ingredients for a brownie!");
        }
    }
}
