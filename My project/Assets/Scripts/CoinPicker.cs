using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinPicker : MonoBehaviour
{
    private float coins = 0;
    private TMP_Text coinsText;

    private GameObject panel;
    private GameObject congrats;

    // Start is called before the first frame update
    private void Start()
    {
        coinsText = GameObject.FindGameObjectWithTag("coins_text").GetComponent<TMP_Text>();
        panel = GameObject.FindGameObjectWithTag("PausePanel"); 
        congrats = GameObject.FindGameObjectWithTag("Congrats");
    }

    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.CompareTag("Coin"))
        {
            coins++;
            coinsText.text = coins.ToString();
            Destroy(coll.gameObject);

            if (coins == 1)
            {
                panel.SetActive(true);
                congrats.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }
}
