using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{
    private AudioSource finishSound;

    void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        finishSound.Play();
        CompleteLevel();
    }

    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
