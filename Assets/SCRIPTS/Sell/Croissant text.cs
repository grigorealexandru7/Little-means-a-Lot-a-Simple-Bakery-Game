using UnityEngine;
using TMPro;
public class Croissanttext : MonoBehaviour
{
    public TMP_Text croissant;
    public Maderecipes maderecipes;
    public CoinCounter coinCounter;
    public AudioSource audioSource;
    public AudioClip Coins;
    private void OnMouseDown()
    {
        if (croissant.text != "0")
        {
            maderecipes.Croissant--;
            croissant.text =maderecipes.Bread.ToString();
            coinCounter.ChangeCoins(12);
            audioSource.PlayOneShot(Coins);
        }
            
    }
}
