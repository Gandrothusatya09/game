using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler2 : MonoBehaviour
{
   

    [SerializeField] PlayerController PlayerController;
    private float levelLoadDelay = 3f;
    AudioSource audioSource;
    [SerializeField] AudioClip successClip;
    [SerializeField] AudioClip deathClip;

    [SerializeField] AudioClip coinClip;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void OnCollisionEnter(UnityEngine.Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Obstacle":
                Fail();
                break;

            default:
                Debug.Log("No Tag");
                break;

        }
    }
    void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Finish":
                success();
                break;
            case "Coins":
                points();
                break;

        }
    }
    void points()
    {
        PlayerController.enabled = true;
        audioSource.Stop();
        audioSource.PlayOneShot(coinClip);
    }
    void success()
    {
        PlayerController.enabled = false;
        audioSource.Stop();
        audioSource.PlayOneShot(successClip);
        Invoke("LoadNextLevel", levelLoadDelay);
    }
    void Fail()
    {

        PlayerController.enabled = false;
        audioSource.Stop();
        audioSource.enabled = true;

        audioSource.PlayOneShot(deathClip);
        Invoke("ReloadLevel", levelLoadDelay);

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



