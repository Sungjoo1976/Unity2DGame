using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ItemCollector : MonoBehaviour
{

    public int fruits = 0;

    [SerializeField] private Text fruitsText;
    [SerializeField] private AudioSource collectSoundEffect;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            collectSoundEffect.Play();
            Destroy(collision.gameObject);
            fruits++;
            fruitsText.text = "Fruits: " + fruits;
        }
        if (collision.gameObject.CompareTag("Apple"))
        {
            collectSoundEffect.Play();
            Destroy(collision.gameObject);
            fruits++;
            fruitsText.text = "Fruits: " + fruits;
        }
        if (collision.gameObject.CompareTag("NextLevel"))
        {
            if(fruits == 3)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
