using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthtest2 : MonoBehaviour
{
    // Start is called before the first frame update
    public void woah()
    {
        if (name == "woah0")
        {
            Healthbar.Fufillment += 1;
            Healthbar.Anxiety -= 1;
        }
        if (name == "woah1")
        {
            Healthbar.Anxiety += 1;
        }

        if (name == "woah2")
        {
            Healthbar.Anxiety += 1;
        }
        
    }
}
