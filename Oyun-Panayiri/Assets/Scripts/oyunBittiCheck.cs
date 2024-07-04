using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class oyunBittiCheck : MonoBehaviour
{
    public GameObject büyükÜçgen1;
    public GameObject büyükÜçgen2;
    public GameObject küçükÜçgen1;
    public GameObject küçükÜçgen2;
    public GameObject paralelkenar;
    public GameObject ortancaÜçgen;
    public GameObject kare;



    public TextMeshProUGUI tebrikText;

    private bool geçiþÝzinli = false;
    private float hedefMesafe = 0.0001f;
    private float hedefMesafe2 = 1f;

    void Update()
    {
        if (!geçiþÝzinli &&
             (Vector3.Distance(büyükÜçgen1.transform.position, new Vector3(-0.464000016f, 1.25392437f, 3.30099988f)) < hedefMesafe ||
             Vector3.Distance(büyükÜçgen2.transform.position, new Vector3(-0.464000016f, 1.25392437f, 3.30099988f)) < hedefMesafe) &&
             (Vector3.Distance(büyükÜçgen1.transform.position, new Vector3(-1.41700006f, 1.2499243f, 3.00199986f)) < hedefMesafe ||
             Vector3.Distance(büyükÜçgen2.transform.position, new Vector3(-1.41700006f, 1.2499243f, 3.00199986f)) < hedefMesafe) &&
             (Vector3.Distance(küçükÜçgen1.transform.position, new Vector3(-1.11699998f, 1.12899995f, 2.98300004f)) < hedefMesafe ||
             Vector3.Distance(küçükÜçgen2.transform.position, new Vector3(-1.11699998f, 1.12899995f, 2.98300004f)) < hedefMesafe) &&
             (Vector3.Distance(küçükÜçgen1.transform.position, new Vector3(-1.12300003f, 1.12199998f, 3.65199995f)) < hedefMesafe ||
             Vector3.Distance(küçükÜçgen2.transform.position, new Vector3(-1.12300003f, 1.12199998f, 3.65199995f)) < hedefMesafe) &&
             Vector3.Distance(paralelkenar.transform.position, new Vector3(-0.463f, 2.04892445f, 2.95600009f)) < hedefMesafe &&
             Vector3.Distance(ortancaÜçgen.transform.position, new Vector3(-1.71000004f, 1.17499995f, 2.671f)) < hedefMesafe &&
             Vector3.Distance(kare.transform.position, new Vector3(-0.773000002f, 1.23199999f, 3.63499999f)) < hedefMesafe

            )

        {
            geçiþÝzinli = true;
            tebrikText.text = "Tebrikler, tüm levelleri tamamlayarak oyunu tamamladýnýz :) Baþlangýç ekranýna yönlendiriliyorsunuz.";
            Invoke("GeçiþYap", 2f); // 2 saniye bekleyip GeçiþYap fonksiyonunu çaðýrýr
        }
    }

    void GeçiþYap()
    {
        SceneManager.LoadScene("baþlangýçEkraný"); // TangramLevel2 sahnesine geçiþ yapar
    }





    public void OnStartButtonClicked()
    {
        // SceneManager kullanarak baþlangýç sahnesine geçiþ
        SceneManager.LoadScene("baþlangýçEkraný");
    }
}

