using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Congtars : MonoBehaviour
{
    public GameObject panel;
    public GameObject congrats;

    private TMP_Text coinsText;

    private void Start(){
        coinsText = GameObject.FindGameObjectWithTag("coins_text").GetComponent<TMP_Text>();
    }

    public void Check(){
        if (coinsText.text == "20"){
            panel.SetActive(true);
            congrats.SetActive(true);
            Time.timeScale = 0f;
        }
    }

}
