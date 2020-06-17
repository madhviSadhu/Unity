using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void onClickBack()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void OnClickGame1()
    {
        SceneManager.LoadScene("Game1");
    }

    public void OnClickGame2()
    {
        SceneManager.LoadScene("Game2");
    }

    public void OnClickGame3()
    {
        SceneManager.LoadScene("Game3");
    }
}