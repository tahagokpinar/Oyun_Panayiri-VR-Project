using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public void PlayButton1()
    {
        SceneManager.LoadScene(5);
    }
    public void PlayButton2()
    {
        SceneManager.LoadScene(6);
    }
    public void PlayButton3()
    {
        SceneManager.LoadScene(7);
    }
    public void QuitButton()
    {
        SceneManager.LoadScene(0);
    }
}
