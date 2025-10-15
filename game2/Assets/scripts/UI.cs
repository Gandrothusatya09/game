using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
   public void Play()
    {
        SceneManager.LoadScene("SampleScene");

    }
    public void Quit()
    {
        Debug.LogWarning("Application closed");
        Application.Quit();
    }
}
