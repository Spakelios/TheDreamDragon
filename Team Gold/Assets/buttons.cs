using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class buttons : MonoBehaviour
{
   public GameObject canvas;
   public void finnishConvo()
   {
      canvas.SetActive(false);
   }
}
