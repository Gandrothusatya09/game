using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    private int coinsCollected;
    [SerializeField] private TextMeshProUGUI scoreText;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Coins")
        {
            coinsCollected++;
            Destroy(other.gameObject);
            scoreText.text = coinsCollected.ToString();
        }
        
    }
}
