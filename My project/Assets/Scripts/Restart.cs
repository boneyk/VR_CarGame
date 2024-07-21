using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject panel;

   public void restart(){
    SceneManager.LoadScene("GameScene");
    Time.timeScale = 1f;
    panel.SetActive(false);
   }
}
