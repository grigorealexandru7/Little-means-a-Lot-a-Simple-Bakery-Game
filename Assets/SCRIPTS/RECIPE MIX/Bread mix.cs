using UnityEngine;

public class Breadmix : MonoBehaviour
{
    public Maderecipes maderecipes;
    public INVENTORY inventory;
    private void OnMouseDown()
    {
        if (inventory.flour_count >= 1 && inventory.yeast_count >= 1)
        {
            inventory.flour_count -= 1;
            inventory.yeast_count -= 1;
            
            maderecipes.Bread++;
            Debug.Log("Great job! You've just made a bread!");
        }
        else
        {
            Debug.Log("Buy more ingredients for a bread!");
        }
            
    }
}
