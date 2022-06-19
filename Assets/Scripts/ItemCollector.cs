using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int cherries = 0;
    private int apples = 0;

    [SerializeField] private Text fruitsText;

    [SerializeField] private AudioSource collectSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            collectSoundEffect.Play();
            Destroy(collision.gameObject);
            cherries++;
            fruitsText.text = "Fruits: " + cherries;
        }
        if (collision.gameObject.CompareTag("Apple"))
        {
            collectSoundEffect.Play();
            Destroy(collision.gameObject);
             fruitsText.text = "Fruits: " + apples;
        }
    }
}
