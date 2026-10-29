using Unity.VisualScripting;
using UnityEngine;

public class Shopopen : MonoBehaviour
{
    private CameraController cameraController;
    
    public GameObject ShopUI; 
    public void OPEN()
    {
        ShopUI.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        cameraController.Sensitivity = 0f;
        
    }
    
    void Update()
    {
        
    }
}
