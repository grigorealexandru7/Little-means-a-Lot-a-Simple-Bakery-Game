using System;
using TMPro;
using UnityEngine;

public class Maderecipes : MonoBehaviour
{
    public int Bread = 0;
    public TMP_Text BreadText;
    
    public int Croissant = 0;
    public TMP_Text CroissantText;
    
    public int Cookie = 0;
    public TMP_Text CookieText;
    
    public int Brownie = 0;
    public TMP_Text BrownieText;
    
    public int Cupcake = 0;
    public TMP_Text CupcakeText;
    
    public int Donut = 0;
    public TMP_Text DonutText;
    
    public int Tart = 0;
    public TMP_Text TartText;
    
    public int Roll = 0;
    public TMP_Text RollText;

    public int Cake = 0;
    public TMP_Text CakeText;
    
    private void Update()
    {
        BreadText.text = Bread.ToString();
        CroissantText.text = Croissant.ToString();
        CupcakeText.text = Cupcake.ToString();
        BrownieText.text = Brownie.ToString();
        CookieText.text = Cookie.ToString();
        DonutText.text = Donut.ToString();
        TartText.text = Tart.ToString();
        RollText.text = Roll.ToString();
        CakeText.text = Cake.ToString();
    }
}
