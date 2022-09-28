using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthtest2 : MonoBehaviour
{
    // Start is called before the first frame update
    public void woah()
    {
        if (name == "woah1")
        {
            Healthbar.Fufillment += 1;
        }
        if (name == "woah0")
        {
            Healthbar.Anxiety += 1;
        }
        
    }
}
