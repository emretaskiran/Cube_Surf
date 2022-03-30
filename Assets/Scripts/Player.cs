using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject bitti_pnl;
    void Start()
    {
        
    }

    void Update()
    {
       
    }
    private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.tag == "Engel")
        {
            GameObject.Find("AnaKup").GetComponent<Hareket>().sagaSolaGitmeHizi = 0;
            GameObject.Find("AnaKup").GetComponent<Hareket>().ileriGitmeHizi = 0;

            bitti_pnl.SetActive(true);
        }
    }





}
