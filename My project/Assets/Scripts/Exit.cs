using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    // Start is called before the first frame update public GameObject panel;

   public GameObject panel;

   public void exit(){
     Application.Quit();
   }
}
