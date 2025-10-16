using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collisionHandler : MonoBehaviour
{
    [SerializeField] moves playerMovement;
    private float levelLoadDelay = 3f;
    AudioSource audioSource;
    [SerializeField] AudioClip successClip;
    [SerializeField] AudioClip deathClip;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.enabled = false;    
    }
     void OnCollisionEnter(UnityEngine.Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Obstacle":
                Fail();
                break;
            case "Finish":
                success();
                break;
            default:
                Debug.Log("No Tag");
                break;

        }
    }
    void success()
    {
        playerMovement.enabled = false;
        audioSource.Stop();
        audioSource.enabled = true;
        audioSource.PlayOneShot(successClip);
        Invoke("LoadNextLevel", levelLoadDelay);
    }
    void Fail()
    {

        playerMovement.enabled = false;
        audioSource.Stop();

        audioSource.PlayOneShot(deathClip);
        Invoke("ReLoadLevel", levelLoadDelay);

    }
    void ReloadLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
    void LoadNextLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);
    }
}

