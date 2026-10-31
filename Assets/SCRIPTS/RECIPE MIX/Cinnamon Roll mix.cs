using UnityEngine;

public class CinnamonRollmix : MonoBehaviour
{
    public Maderecipes maderecipes;
    public INVENTORY inventory;

    public AudioSource audioSource;
    public AudioClip Knead;
    private void OnMouseDown()
    {
        if (inventory.flour_count >= 1 && inventory.milk_count >= 1 && inventory.yeast_count >= 1 &&
            inventory.eggs_count >= 1 && inventory.sugar_count >= 2 && inventory.butter_count >= 3 &&
            inventory.creamcheese_count >= 1 && inventory.powdersugar_count >= 1 &&
            inventory.vanillaextract_count >= 1 && inventory.condensedmilk_count >= 1 && inventory.cinnamon_count >= 3)
        {
            inventory.flour_count -= 1;
            inventory.milk_count -= 1;
            inventory.yeast_count -= 1;
            inventory.eggs_count -= 1;
            inventory.sugar_count -= 2;
            inventory.butter_count -= 3;
            inventory.creamcheese_count -= 1;
            inventory.powdersugar_count -= 1;
            inventory.vanillaextract_count -= 1;
            inventory.condensedmilk_count -= 1;
            inventory.cinnamon_count -= 3;

            audioSource.PlayOneShot(Knead);

            maderecipes.Roll++;
            Debug.Log("Great job! You've just made a cinnmon roll!");
        }
        else
        {
            Debug.Log("Buy more ingredients for a cinnamon roll!");
        }
    }
}
