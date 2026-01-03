using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScreen : MonoBehaviour
{

public void GoToGame()
    {
        SceneManager.LoadScene("GameScreen1");
    }
}
