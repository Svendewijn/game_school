using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pain : MonoBehaviour
{
	public int maxHealth = 3;
	public int currentHealth;

	public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.P))
		{
			TakeDamage(1);
		}
	
		if (currentHealth <= 0.1)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
		}
    }
	void TakeDamage(int damage)
	{
		currentHealth -= damage;

		healthBar.SetHealth(currentHealth);
	}
}