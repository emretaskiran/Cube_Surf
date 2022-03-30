using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toplayici : MonoBehaviour
{
    GameObject anaKup;
    int yukseklik;
    int click = 0;
    int puan;
    public Text puan_txt;
    public Text sonpuan_txt;

    void Start()
    {
        anaKup = GameObject.Find("AnaKup");
        
    }

    void Update()
    {
        anaKup.transform.position = new Vector3(transform.position.x, yukseklik + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -yukseklik, 0);
        puan = click * 100;
        puan_txt.text = "SKOR: " + puan;

        sonpuan_txt.text = "SKOR: " + puan;
    }

    public void YukseklikAzalt()
    {
        yukseklik--;
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Topla" && other.gameObject.GetComponent<ToplanabilirKup>().GetToplandiMi()==false)
        {
            yukseklikartirma();
            other.gameObject.GetComponent<ToplanabilirKup>().ToplandiYap();
            other.gameObject.transform.parent = anaKup.transform;
            other.gameObject.GetComponent<ToplanabilirKup>().IndexAyarla(yukseklik);
            


        }
    }
    private void yukseklikartirma()
    {
        yukseklik += 1;
        click++;
    }

    

}
