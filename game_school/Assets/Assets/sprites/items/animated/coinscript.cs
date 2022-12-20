using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class coinscript : MonoBehaviour

{
    public int value;

    private void OnTriggerEnter2D(Collider2D other)
    { 
            
            CoinCounter.instance.IncreaseCoins(value);
            Destroy(gameObject);
    }
}