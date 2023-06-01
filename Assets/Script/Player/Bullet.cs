using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        if (collision.tag == "Monster")
        {
            collision.GetComponent<Blu>().TakeDamage(25);
            Destroy(gameObject);
        }
        if (collision.tag == "LittleMonster")
        {
            collision.GetComponent<Yillo>().TakeDamage(25);
            Destroy(gameObject);
        }
        
        
    }
}
