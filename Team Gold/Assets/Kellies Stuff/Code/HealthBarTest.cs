using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBarTest : MonoBehaviour
{
    public  Slider AuntBar;
    public  Slider AnxietyBar;
    
    
    void Start()
    {
        if(Healthbar.Fufillment == 1)
        {
            AuntBar.value = 0.5f;
        }
        else if (Healthbar.Fufillment == 2)
        {
            AuntBar.value = 0.7f;
        }
        else if (Healthbar.Fufillment == 3)
        {
            AuntBar.value = 2f;
            Healthbar.Fufillment = 2;
        }
        else if (Healthbar.Fufillment == 4)
        {
            AuntBar.value = 2f;
            
        }

        if(Input.GetKeyDown("s"))
        {
            Healthbar.Anxiety += 1;
            AnxietyBar.value += 0.1f;
        }
    }

    private void Update()
    {
        if(Healthbar.Fufillment == 1)
        {
            AuntBar.value = 0.5f;
            
        }
        else if (Healthbar.Fufillment == 2)
        {
            AuntBar.value = 0.7f;
        }
        else if (Healthbar.Fufillment == 3)
        {
            AuntBar.value = 1f;
        }
        
        if(Healthbar.Anxiety == 1)
        {
            AnxietyBar.value = 1f;
        }
        else if (Healthbar.Anxiety == 2)
        {
            AnxietyBar.value = 0.5f;
        }
        else if (Healthbar.Anxiety == 3)
        {
            AnxietyBar.value = 0f;
        }
    }
}
