using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinPicker : MonoBehaviour
{
    private float coins = 0;
    private TMP_Text coinsText;

    // Start is called before the first frame update
    private void Start()
    {
        coinsText = GameObject.FindGameObjectWithTag("coins_text").GetComponent<TMP_Text>();
    }

    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.CompareTag("Coin"))
        {
            coins++;
            coinsText.text = coins.ToString();
            Destroy(coll.gameObject);
        }
    }
}
