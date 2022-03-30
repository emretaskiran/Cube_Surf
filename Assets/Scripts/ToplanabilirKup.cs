using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToplanabilirKup : MonoBehaviour
{
    bool toplandiMi;
    int index;
    public Toplayici toplayici;

    public GameObject seviye_pnl;

    void Start()
    {
        toplandiMi = false;
        
    }

    void Update()
    {
        if (toplandiMi == true)
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -index, 0);

            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Engel")
        {
            toplayici.YukseklikAzalt();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }

        if (other.gameObject.tag == "bitis")
        {
            seviye_pnl.SetActive(true);
            GameObject.Find("AnaKup").GetComponent<Hareket>().sagaSolaGitmeHizi = 0;
            GameObject.Find("AnaKup").GetComponent<Hareket>().ileriGitmeHizi = 0;


        }
        
    }

    public bool GetToplandiMi()
    {
        return toplandiMi;
    }

    public void ToplandiYap()
    {
        toplandiMi = true;
    }

    public void IndexAyarla(int index)
    {
        this.index = index;
    }
}
