using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    [SerializeField] private string sceneName = "SampleScene";

    public void PlayGame()
    {
        SceneManager.LoadScene(sceneName);
    }
  
}