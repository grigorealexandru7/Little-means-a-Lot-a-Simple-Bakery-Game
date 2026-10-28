using UnityEngine;

public class Quitshopbutton : MonoBehaviour
{
    
    public GameObject ShopUI; 
    public void PRESS()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        ShopUI.SetActive(false);
    }
    
    void Update()
    {
        
    }
}
