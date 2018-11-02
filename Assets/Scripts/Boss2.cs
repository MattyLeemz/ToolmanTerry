using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss2 : MonoBehaviour {

    public int health = 700;
    [SerializeField]
    GameObject enemyBullet;

    float fireRate;
    float nextFire;

    void Start()
    {
        fireRate = 0.5f;
        nextFire = Time.time;
    }

    void Update()
    {
        CheckIfTimeToFire();
    }

    void CheckIfTimeToFire()
    {
        if (Time.time > nextFire)
        {
            Instantiate(enemyBullet, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
    }

    public GameObject deathEffect;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}