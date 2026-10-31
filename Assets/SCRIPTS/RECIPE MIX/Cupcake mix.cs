using UnityEngine;

public class Cupcakemix : MonoBehaviour
{
    public Maderecipes maderecipes;
    public INVENTORY inventory;

    public AudioSource audioSource;
    public AudioClip Knead;
    private void OnMouseDown()
    {
        if (inventory.flour_count >= 1 && inventory.sugar_count >= 1 && inventory.butter_count >= 1 &&
            inventory.eggs_count >= 1 && inventory.milk_count >= 1 && inventory.bakingsoda_count >= 1 &&
            inventory.powdersugar_count >= 1 && inventory.whippedcream_count >= 1 &&
            inventory.vanillaextract_count >= 1 && inventory.sprinkles_count >= 3)
        {
            inventory.flour_count -= 1;
            inventory.sugar_count -= 1;
            inventory.butter_count -= 1;
            inventory.eggs_count -= 1;
            inventory.milk_count -= 1;
            inventory.bakingsoda_count -= 1;
            inventory.powdersugar_count -= 1;
            inventory.whippedcream_count -= 1;
            inventory.vanillaextract_count -= 1;
            inventory.sprinkles_count -= 3;

            audioSource.PlayOneShot(Knead);
            
            maderecipes.Cupcake++;
            Debug.Log("Great job! You've just made a cupcake!");
        }
        else
        {
            Debug.Log("Buy more ingredients for a cupcake!");
        }
    }
}
