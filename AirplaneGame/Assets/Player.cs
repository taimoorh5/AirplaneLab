using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int playerHealth = 100;
    public GameObject deathEffect;
    public Text pHealth;
    
    void Update(){
        pHealth.text = "PlayerHealth - " + playerHealth;
    }

    public void takeDamage (int damage) 
    {
        playerHealth -= damage;
        if(playerHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        Scene current = SceneManager.GetActiveScene();
        int newindex = current.buildIndex;
        Debug.Log ("Restarting Level: " + newindex);
        SceneManager.LoadScene(newindex);
    }
}