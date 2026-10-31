using UnityEngine;
using TMPro;
public class Rolltext : MonoBehaviour
{
    public TMP_Text roll;
    public Maderecipes maderecipes;
    public CoinCounter coinCounter;
    public AudioSource audioSource;
    public AudioClip Coins;
    private void OnMOuseDown()
    {
        if (roll.text != "0")
        {
            maderecipes.Roll--;
            roll.text=maderecipes.Roll.ToString();
            coinCounter.ChangeCoins(68);
            audioSource.PlayOneShot(Coins);
        }
            
    }
}
