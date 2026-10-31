using UnityEngine;
using TMPro;
public class Brownietext : MonoBehaviour
{
    public TMP_Text brownie;
    public Maderecipes maderecipes;
    public CoinCounter coinCounter;
    public AudioSource audioSource;
    public AudioClip Coins;
    private void OnMouseDown()
    {
        if (brownie.text != "0")
        {
            maderecipes.Brownie--;
            brownie.text = maderecipes.Brownie.ToString();
            coinCounter.ChangeCoins(28);
            audioSource.PlayOneShot(Coins);
        }
    }
}
