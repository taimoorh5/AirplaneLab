using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBulletMovement : MonoBehaviour
{
    public float enemyBulletSpeed = 15f;
    public Rigidbody2D rb;
    public int playerDamage = 10;
    public GameObject impactEffect;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * enemyBulletSpeed;
    }

    void OnTriggerEnter2D(Collider2D collision) 
    {
        Player player = collision.GetComponent<Player>();
        if(player != null)
        {
            player.takeDamage(playerDamage);
        }

        Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
