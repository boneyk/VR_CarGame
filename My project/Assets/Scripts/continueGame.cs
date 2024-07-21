using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class continueGame : MonoBehaviour
{
    // Start is called before the first frame update
   public GameObject panel;

   public void Continue(){
    Time.timeScale = 1f;
    panel.SetActive(false);
   }
}
