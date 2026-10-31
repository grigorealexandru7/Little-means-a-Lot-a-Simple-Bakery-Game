using UnityEngine;
using TMPro;
public class Cupcaketext : MonoBehaviour
{
    public TMP_Text cupcake;
    public Maderecipes maderecipes;
    public CoinCounter coinCounter;
    public AudioSource audioSource;
    public AudioClip Coins;
    private void OnMouseDown()
    {
        if (cupcake.text != "0")
        {
            maderecipes.Cupcake--;
            cupcake.text = maderecipes.Cupcake.ToString();
            coinCounter.ChangeCoins(40);
            audioSource.PlayOneShot(Coins);
        }
    }
}
