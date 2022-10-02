using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class changescene : MonoBehaviour
{
    public GameObject talk;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("diocane");
        if (collision.tag == "Player")
            // SceneManager.LoadScene("PrototypeVN", LoadSceneMode.Single);
            talk.SetActive(true);
    }


}
