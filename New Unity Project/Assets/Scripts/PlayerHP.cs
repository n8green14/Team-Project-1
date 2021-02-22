using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHp : MonoBehaviour
{
    public int hP = 2;
    public bool hasDied;

    void Start()
    {
        hasDied = false;
    }

    void Update()
    {
        if (hP <= 0)
        {
            Die();
        }
        if (gameObject.transform.position.y < -5)
        {
            Die();
        }
    }

    void Die()
    {
        SceneManager.LoadScene("GameOver");
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            --hP;
        }
    }
}
