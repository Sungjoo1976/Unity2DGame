using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoStart : MonoBehaviour
{
    // Start is called before the first frame update
    public void GoStart()
    {
        SceneManager.LoadScene("StartScene");
    }
}
