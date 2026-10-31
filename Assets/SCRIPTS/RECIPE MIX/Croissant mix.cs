using UnityEngine;

public class Croissantmix : MonoBehaviour
{
    public Maderecipes maderecipes;
    public INVENTORY inventory;
    
    public AudioSource audioSource;
    public AudioClip knead;
    private void OnMouseDown()
    {
        if (inventory.flour_count >= 1 && inventory.milk_count >= 1 && inventory.yeast_count >= 1 &&
            inventory.sugar_count >= 1 && inventory.butter_count >= 1)
        {
            inventory.flour_count -= 1;
            inventory.milk_count -= 1;
            inventory.yeast_count -= 1;
            inventory.sugar_count -= 1;
            inventory.butter_count -= 1;

            audioSource.PlayOneShot(knead);
            
            maderecipes.Croissant++;
            Debug.Log("Great job! You've just made a croissant!");
        }
        else
        {
            Debug.Log("Buy more ingredients for a croissant!");
        }
    }
}
