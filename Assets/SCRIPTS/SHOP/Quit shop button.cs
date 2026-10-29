using UnityEngine;

public class Quitshopbutton : MonoBehaviour
{
    private CameraController cameraController;
    public GameObject ShopUI; 
    public void PRESS()
    {
        ShopUI.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        cameraController.Sensitivity = 250f;
    }
    
    void Update()
    {
        
    }
}
