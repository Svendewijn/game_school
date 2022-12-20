using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spikedamage : MonoBehaviour


{
	public bool playerIsClose;
    public int InvulnerabilityTime = 4;
    AudioSource source;
	public int maxHealth = 3;
	public int currentHealth;
    private bool isTakingDamage = false; 

	public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
		if (playerIsClose && isTakingDamage == false)
		{
            TakeDamage(1);
            isTakingDamage = true;
            StartCoroutine(damage());
		}

		if (currentHealth <= 0.1)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
		}
    }

	void TakeDamage(int damage)
	{
		currentHealth -= damage;
        source.Play();
		healthBar.SetHealth(currentHealth);
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
    IEnumerator damage() {
        yield return new WaitForSeconds(InvulnerabilityTime);
        isTakingDamage = false;
    }
}