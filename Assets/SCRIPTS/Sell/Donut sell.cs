using TMPro;
using UnityEngine;

public class Donutsell : MonoBehaviour
{
    public TMP_Text donut;
    public Maderecipes maderecipes;
    public CoinCounter coinCounter;
    public AudioSource audioSource;
    public AudioClip Coins;
    private void OnMouseDown()
    {
        if (donut.text != "0")
        {
            maderecipes.Donut--;
            donut.text=maderecipes.Donut.ToString();
            coinCounter.ChangeCoins(44);
            audioSource.PlayOneShot(Coins);
        }
    }
}
