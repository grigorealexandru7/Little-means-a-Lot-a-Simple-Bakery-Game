using UnityEngine;
using TMPro;
public class Caketext : MonoBehaviour
{
    public TMP_Text cake;
    public Maderecipes maderecipes;
    public CoinCounter coinCounter;
    public AudioSource audioSource;
    public AudioClip Coins;
    private void OnMouseDown()
    {
        if (cake.text != "0")
        {
            maderecipes.Cake--;
            cake.text=maderecipes.Cake.ToString();
            coinCounter.ChangeCoins(100);
            
            audioSource.PlayOneShot(Coins);
}
    }
}
