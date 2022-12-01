using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class deathbox : MonoBehaviour
{
    public bool playerIsClose;



        // Update is called once per frame
    void Update()
    {
         if (playerIsClose)
        {
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
        }
   	}
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = true;
        }
    }
    
        private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = false;
        
        }
    }
}
