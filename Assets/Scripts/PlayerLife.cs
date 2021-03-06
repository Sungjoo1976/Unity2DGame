using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    

    private Rigidbody2D rb;
    private Animator anim;
    private int lifes = 3;

    [SerializeField] private Text lifeText;
    [SerializeField] private AudioSource deathSoundEffect;
    [SerializeField] Transform spawnPoint;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            lifes--;
            lifeText.text = "\r\nLifes: " + lifes;
            Die();
            rb.transform.position = spawnPoint.position;
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            lifes--;
            lifeText.text = "\r\nLifes: " + lifes;
            Die();
            rb.transform.position = spawnPoint.position;

        }
        if (lifes == 0)
        {
            SceneManager.LoadScene("EndScene");
        }

    }

    private void Die()
    {
        deathSoundEffect.Play();
        //rb.bodyType = RigidbodyType2D.Static;
        //anim.SetTrigger("death");
    }
    /*
    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }*/
}
