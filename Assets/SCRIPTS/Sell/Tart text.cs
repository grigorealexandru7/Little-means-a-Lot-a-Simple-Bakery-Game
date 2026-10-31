using UnityEngine;
using TMPro;
public class Tarttext : MonoBehaviour
{
    public TMP_Text tart;
    public Maderecipes maderecipes;
    public CoinCounter coinCounter;
    public AudioSource audioSource;
    public AudioClip Coins;
    private void OnMouseDown()
    {
        if (tart.text != "0")
        {
            maderecipes.Tart--;
            tart.text = maderecipes.Tart.ToString();
            coinCounter.ChangeCoins(47);
            audioSource.PlayOneShot(Coins);
        }
    }
}
