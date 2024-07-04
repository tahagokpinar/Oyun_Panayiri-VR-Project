using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class baslangıc : MonoBehaviour
{
    // Button'a tıklandığında çağrılacak fonksiyon
    public void OnStartButtonClicked()
    {
        // SceneManager kullanarak sahne geçişi
        SceneManager.LoadScene("TangramLevel1");
    }
}
