using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D rb;
   
	// Use this for initialization
	void Start () {
        rb.velocity = transform.right * speed;
	}
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
            Destroy(gameObject);
        }

        Enemy2 enemy2 = hitInfo.GetComponent<Enemy2>();
        if (enemy2 != null)
        {
            enemy2.TakeDamage(damage);
            Destroy(gameObject);
        }

        Enemy3 enemy3 = hitInfo.GetComponent<Enemy3>();
        if (enemy3 != null)
        {
            enemy3.TakeDamage(damage);
            Destroy(gameObject);
        }

        Enemy4 enemy4 = hitInfo.GetComponent<Enemy4>();
        if (enemy4 != null)
        {
            enemy4.TakeDamage(damage);
            Destroy(gameObject);
        }

        Boss1 boss1 = hitInfo.GetComponent<Boss1>();
        if (boss1 != null)
        {
            boss1.TakeDamage(damage);
            Destroy(gameObject);
        }
    }

}

