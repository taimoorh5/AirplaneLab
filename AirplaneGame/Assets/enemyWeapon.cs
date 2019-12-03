using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyWeapon : MonoBehaviour
{
    public Transform enemyFirePoint;
    public GameObject enemyBulletPrefab;


    // Update is called once per frame
    void Start ()
    {
        InvokeRepeating("enemyShoot", 0, 0.75f);
    }

    void enemyShoot()
    {
        Instantiate(enemyBulletPrefab, enemyFirePoint.position, enemyFirePoint.rotation);
    }
}
