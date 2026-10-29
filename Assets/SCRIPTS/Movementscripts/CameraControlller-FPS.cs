using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float Sensitivity =250f;
    private float xRotation =0f;
    public GameObject ShopUI; 
    public void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * Sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * Sensitivity;
        
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -75f, 75f);
        
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.parent.Rotate(Vector3.up * mouseX);
    }
}
