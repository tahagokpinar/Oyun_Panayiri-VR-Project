using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class level2check : MonoBehaviour

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
    private float hedefMesafe = 0.0001f;
    private float hedefMesafe2 = 1f;

    void Update()
    {
        if (!geçişİzinli &&
             (Vector3.Distance(büyükÜçgen1.transform.position, new Vector3(-1.04699993f, 1.25092435f, 3.18099999f)) < hedefMesafe ||
             Vector3.Distance(büyükÜçgen2.transform.position, new Vector3(-1.04699993f, 1.25092435f, 3.18099999f)) < hedefMesafe) &&
             (Vector3.Distance(büyükÜçgen1.transform.position, new Vector3(-1.06000006f, 1.24292433f, 3.19499993f)) < hedefMesafe ||
             Vector3.Distance(büyükÜçgen2.transform.position, new Vector3(-1.06000006f, 1.24292433f, 3.19499993f)) < hedefMesafe) &&
             (Vector3.Distance(küçükÜçgen1.transform.position, new Vector3(-1.61399996f, 1.12899995f, 3.77200007f)) < hedefMesafe ||
             Vector3.Distance(küçükÜçgen2.transform.position, new Vector3(-1.61399996f, 1.12899995f, 3.77200007f)) < hedefMesafe) &&
             (Vector3.Distance(küçükÜçgen1.transform.position, new Vector3(-1.28299999f, 1.12100005f, 2.76699996f)) < hedefMesafe ||
             Vector3.Distance(küçükÜçgen2.transform.position, new Vector3(-1.28299999f, 1.12100005f, 2.76699996f)) < hedefMesafe) &&
             Vector3.Distance(paralelkenar.transform.position, new Vector3(-0.0640000105f, 2.04892445f, 3.23300004f)) < hedefMesafe &&
             Vector3.Distance(ortancaÜçgen.transform.position, new Vector3(-1.23899996f, 1.16799998f, 2.7670002f)) < hedefMesafe &&
             Vector3.Distance(kare.transform.position, new Vector3(-1.70599997f, 1.23199999f, 3.54299998f)) < hedefMesafe
             
            )

        {
            geçişİzinli = true;
            tebrikText.text = "Tebrikler, basardiniz! Yeni level baslatiliyor...";
            Invoke("GeçişYap", 2f); // 2 saniye bekleyip GeçişYap fonksiyonunu çağırır
        }
    }

    void GeçişYap()
    {
        SceneManager.LoadScene(3); // TangramLevel2 sahnesine geçiş yapar
    }





    public void OnStartButtonClicked()
    {
        // SceneManager kullanarak başlangıç sahnesine geçiş
        SceneManager.LoadScene("başlangıçEkranı");
    }
}
