using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public int enemyHealth = 100;
    public GameObject deathEffect;
    public Text eHealth;

    void Update(){
        eHealth.text = "EnemyHealth - " + enemyHealth;
    }

    public void takeDamage (int damage) {
        
        enemyHealth -= damage;
        eHealth.text = "EnemyHealth - " + enemyHealth;
        
        if(enemyHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        Scene current = SceneManager.GetActiveScene();
        int newindex = current.buildIndex + 1;
        Debug.Log ("New Level load: " + newindex);
        SceneManager.LoadScene(newindex);
    }
}