using UnityEngine;
using TMPro;
public class Cookietext : MonoBehaviour
{
    public TMP_Text cookie;
    public Maderecipes maderecipes;
    public CoinCounter coinCounter;
    public AudioSource audioSource;
    public AudioClip Coins;
    private void OnMouseDown()
    {
        if (cookie.text != "0")
        {
            maderecipes.Cookie--;
            cookie.text = maderecipes.Cookie.ToString();
            coinCounter.ChangeCoins(15);
            audioSource.PlayOneShot(Coins);
        }
    }
}
