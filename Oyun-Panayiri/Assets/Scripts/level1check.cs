using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class level1check : MonoBehaviour

{
    public GameObject büyükÜçgen1;
    public GameObject büyükÜçgen2;
    public GameObject küçükÜçgen1;
    public GameObject küçükÜçgen2;
    public GameObject paralelkenar;
    public GameObject ortancaÜçgen;
    public GameObject kare;


    public TextMeshProUGUI tebrikText;

    private bool geçişİzinli = false;
    private float hedefMesafe = 0.1f;
    

    void Update()
    {
        if (!geçişİzinli &&
             (Vector3.Distance(büyükÜçgen1.transform.position, new Vector3(-0.968999982f, 1.32099998f, 3.12700009f)) < hedefMesafe ||
             Vector3.Distance(büyükÜçgen2.transform.position, new Vector3(-0.968999982f, 1.32099998f, 3.12700009f)) < hedefMesafe) &&
             (Vector3.Distance(büyükÜçgen1.transform.position, new Vector3(-0.713f, 1.32000005f, 2.91000009f)) < hedefMesafe ||
             Vector3.Distance(büyükÜçgen2.transform.position, new Vector3(-0.713f, 1.32000005f, 2.91000009f)) < hedefMesafe) &&
             (Vector3.Distance(küçükÜçgen1.transform.position, new Vector3(-0.250999987f, 1.20500004f, 2.33599997f)) < hedefMesafe ||
             Vector3.Distance(küçükÜçgen2.transform.position, new Vector3(-0.250999987f, 1.20500004f, 2.33599997f)) < hedefMesafe) &&
             (Vector3.Distance(küçükÜçgen1.transform.position, new Vector3(-1.63900006f, 1.20500004f, 2.9289999f)) < hedefMesafe ||
             Vector3.Distance(küçükÜçgen2.transform.position, new Vector3(-1.63900006f, 1.20500004f, 2.9289999f)) < hedefMesafe) &&
             Vector3.Distance(paralelkenar.transform.position, new Vector3(-0.748000026f, 1.98800004f, 2.9000001f)) < hedefMesafe &&
             Vector3.Distance(ortancaÜçgen.transform.position, new Vector3(-1.24100006f, 1.23500001f, 2.98000002f)) < hedefMesafe &&
             Vector3.Distance(kare.transform.position, new Vector3(-0.943000019f, 1.28799999f, 3.5f)) < hedefMesafe

             )

        {
            geçişİzinli = true;
            tebrikText.text = "Tebrikler, basardiniz! Yeni level baslatiliyor...";
            Invoke("GeçişYap", 3f); // 3 saniye bekleyip GeçişYap fonksiyonunu çağırır
        }
    }

    void GeçişYap()
    {
        SceneManager.LoadScene(2); // TangramLevel2 sahnesine geçiş yapar
    }





    public void OnStartButtonClicked()
    {
        // SceneManager kullanarak sahne geçişi
        SceneManager.LoadScene("TangramLevel1");
    }
}
