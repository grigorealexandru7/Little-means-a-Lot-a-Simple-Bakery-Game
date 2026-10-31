using TMPro;
using UnityEngine;

public class Breadtext : MonoBehaviour
{
    public TMP_Text bread;
    public Maderecipes maderecipes;
    public CoinCounter coinCounter;
    public AudioSource audioSource;
    public AudioClip Coins;
    private void OnMouseDown()
    {
        if (bread.text != "0")
        {
            maderecipes.Bread--;
            bread.text =maderecipes.Bread.ToString();
            coinCounter.ChangeCoins(5);
            audioSource.PlayOneShot(Coins);
        }
            
    }
}
