using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KiwiCollect : MonoBehaviour
{
    [SerializeField] private AudioSource collectSoundEffect;
    [SerializeField] Text TimerText;
    [SerializeField] float setTime = 60.0f;
    private bool EatKiwi = false;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Kiwi"))
        {
            EatKiwi=true;
            collectSoundEffect.Play();
            Destroy(collision.gameObject);
            TimerText.text = setTime.ToString();
            Update();
        }
    }

    private void Update()
    {
        if (setTime > 0)
        {
            setTime -= Time.deltaTime;
        }
        else if (setTime <= 0)
        {
            Time.timeScale = 0.0f;
            if (EatKiwi == true)
            {
                SceneManager.LoadScene("FinishScene");
            }
            else
            {
                SceneManager.LoadScene("EndScene");
            }
            
        }
        TimerText.text = Mathf.Round(setTime).ToString();
    }
}
