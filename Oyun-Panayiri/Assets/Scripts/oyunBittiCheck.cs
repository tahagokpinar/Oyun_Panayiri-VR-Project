using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class oyunBittiCheck : MonoBehaviour
{
    public GameObject b�y�k��gen1;
    public GameObject b�y�k��gen2;
    public GameObject k���k��gen1;
    public GameObject k���k��gen2;
    public GameObject paralelkenar;
    public GameObject ortanca��gen;
    public GameObject kare;



    public TextMeshProUGUI tebrikText;

    private bool ge�i��zinli = false;
    private float hedefMesafe = 0.0001f;
    private float hedefMesafe2 = 1f;

    void Update()
    {
        if (!ge�i��zinli &&
             (Vector3.Distance(b�y�k��gen1.transform.position, new Vector3(-0.464000016f, 1.25392437f, 3.30099988f)) < hedefMesafe ||
             Vector3.Distance(b�y�k��gen2.transform.position, new Vector3(-0.464000016f, 1.25392437f, 3.30099988f)) < hedefMesafe) &&
             (Vector3.Distance(b�y�k��gen1.transform.position, new Vector3(-1.41700006f, 1.2499243f, 3.00199986f)) < hedefMesafe ||
             Vector3.Distance(b�y�k��gen2.transform.position, new Vector3(-1.41700006f, 1.2499243f, 3.00199986f)) < hedefMesafe) &&
             (Vector3.Distance(k���k��gen1.transform.position, new Vector3(-1.11699998f, 1.12899995f, 2.98300004f)) < hedefMesafe ||
             Vector3.Distance(k���k��gen2.transform.position, new Vector3(-1.11699998f, 1.12899995f, 2.98300004f)) < hedefMesafe) &&
             (Vector3.Distance(k���k��gen1.transform.position, new Vector3(-1.12300003f, 1.12199998f, 3.65199995f)) < hedefMesafe ||
             Vector3.Distance(k���k��gen2.transform.position, new Vector3(-1.12300003f, 1.12199998f, 3.65199995f)) < hedefMesafe) &&
             Vector3.Distance(paralelkenar.transform.position, new Vector3(-0.463f, 2.04892445f, 2.95600009f)) < hedefMesafe &&
             Vector3.Distance(ortanca��gen.transform.position, new Vector3(-1.71000004f, 1.17499995f, 2.671f)) < hedefMesafe &&
             Vector3.Distance(kare.transform.position, new Vector3(-0.773000002f, 1.23199999f, 3.63499999f)) < hedefMesafe

            )

        {
            ge�i��zinli = true;
            tebrikText.text = "Tebrikler, t�m levelleri tamamlayarak oyunu tamamlad�n�z :) Ba�lang�� ekran�na y�nlendiriliyorsunuz.";
            Invoke("Ge�i�Yap", 2f); // 2 saniye bekleyip Ge�i�Yap fonksiyonunu �a��r�r
        }
    }

    void Ge�i�Yap()
    {
        SceneManager.LoadScene("ba�lang��Ekran�"); // TangramLevel2 sahnesine ge�i� yapar
    }





    public void OnStartButtonClicked()
    {
        // SceneManager kullanarak ba�lang�� sahnesine ge�i�
        SceneManager.LoadScene("ba�lang��Ekran�");
    }
}

