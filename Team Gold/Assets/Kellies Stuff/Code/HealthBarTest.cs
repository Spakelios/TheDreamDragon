using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBarTest : MonoBehaviour
{
    public Slider AuntBar;
    public Slider AnxietyBar;
    
    
    void Start()
    {
        if(Healthbar.Fufillment == 1)
        {
            AuntBar.value = 0.1f;
            AnxietyBar.value = 0f;
        }

        
        if(Input.GetKeyDown("s"))
        {
            Healthbar.Anxiety += 1;
            AnxietyBar.value += 0.1f;
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Healthbar.Fufillment >= 1)
        {
            AuntBar.value = 1f;
            AnxietyBar.value = 0f;
        }
        
        if(Input.GetKeyDown("s"))
        {
            Healthbar.Anxiety += 1;
            AnxietyBar.value += 0.1f;
            
        }
        
    }
}
