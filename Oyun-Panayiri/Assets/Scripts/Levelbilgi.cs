using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levelbilgi : MonoBehaviour
{
    public int sahnenumarasi;
    public void tamambutton()
    {
        SceneManager.LoadScene(sahnenumarasi);
    }
}
