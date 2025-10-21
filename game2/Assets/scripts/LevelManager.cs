using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;          
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    

    [SerializeField] private Button ResumeBtn;

    [SerializeField] private Button SkipLevelBtn;

    [SerializeField] private Button ExitBtn;

    [SerializeField] private MonoBehaviour playerController;

    [SerializeField] GameObject settingsMenuCard;

    void Start()
    {
        
        ResumeBtn.onClick.AddListener(CloseSettingsFun);
        SkipLevelBtn.onClick.AddListener(skipLevelFun);
        ExitBtn.onClick.AddListener(EXitFun);
        settingsMenuCard.SetActive(false);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            openSettingsFun();
        }
     }


    void openSettingsFun()
    {
        settingsMenuCard.SetActive(true);
        playerController.enabled = false;
    }

    void CloseSettingsFun()
    {
        settingsMenuCard.SetActive(false);
        playerController.enabled = true;
    }

    void EXitFun()
    {
        SceneManager.LoadScene(0);
    }

    void skipLevelFun()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int NextSceneIndex = currentSceneIndex + 1;
        SceneManager.LoadScene(NextSceneIndex);
    }    

}
