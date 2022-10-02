using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astrogoi : MonoBehaviour
{
    public GameObject astrgoi;
    public GameObject player;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        
            astrgoi.SetActive(true);
    
    }

    public void Update()
    {
        if (astrgoi.activeInHierarchy)
        {
           player.SetActive(false);
           
        }
        else
        {
            player.SetActive(true);
            
        }
    }
}
