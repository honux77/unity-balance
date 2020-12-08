using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void Do() { 
         SceneManager.LoadScene("SampleScene");               
    }

    public void End() {
        Application.Quit();
    }
}
