using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void GotoStartScene()
    {
        SceneManager.LoadScene("StartScene");
    }
}
