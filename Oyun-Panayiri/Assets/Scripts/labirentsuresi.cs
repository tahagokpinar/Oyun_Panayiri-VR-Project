using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;
using UnityEngine.SceneManagement;

public class labirentsuresi : MonoBehaviour
{
    public Vector3 entryPointPosition;
    public Vector3 exitPointPosition;
    public TextMeshProUGUI textMeshProObject;
    public GameObject panelGameObject; // Panelin GameObject özelliği
    public int nextlevel;
    public int mainMenu;
    
    private bool labirentBasladi = false;
    private bool labirentTamamlandi = false;
    private float startTime;

    void Start()
    {
        // Başlangıçta paneli gizle
        if (panelGameObject != null)
        {
            panelGameObject.SetActive(false);
        }
    }
    
    void Update()
    {
        if (!labirentTamamlandi)
        {
            // XR Rig'in pozisyonunu al
            Vector3 rigPosition = transform.position;

            // Kullanıcının giriş veya çıkışa ulaşıp ulaşmadığını kontrol et
            if (!labirentBasladi && Vector3.Distance(rigPosition, entryPointPosition) < 1f)
            {
                labirentBasladi = true;
                startTime = Time.time; // Zamanı başlat
            }

            if (labirentBasladi && Vector3.Distance(rigPosition, exitPointPosition) < 1f)
            {
                LabirentiTamamla();
            }
        }
    }

    void LabirentiTamamla()
    {
        labirentTamamlandi = true;
        float completionTime = Time.time - startTime; // Tamamlanma süresini hesapla

        float minutes = Mathf.Floor(completionTime / 60);
        float seconds = completionTime % 60;
        
        string tamamlamaMetni = minutes.ToString("00") + ":" + seconds.ToString("00");
        
        // Kullanıcının belirlediği TextMeshPro nesnesine tamamlama süresini yazdır
        if (textMeshProObject != null)
        {
            textMeshProObject.text = tamamlamaMetni;
        }
        
        if (panelGameObject != null)
        {
            panelGameObject.SetActive(true);
        }
    }
    public void nextLevelbutton()
    {
        SceneManager.LoadScene(nextlevel);
    }
    public void mainMenuButton()
    {
        SceneManager.LoadScene(mainMenu);
    }

    public void quitButton()
    {
        SceneManager.LoadScene(0);
    }
}
