using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menucon : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene("talk1");
    }
    public void Continue()
    {
        SceneManager.LoadScene("talk2");
    }
    public void Continuesecond()
    {
        SceneManager.LoadScene("jopa"); 
    }
    public void restart()
    {
        SceneManager.LoadScene("Menu"); 
    }
    public void Exit()
    {
        Application.Quit();
    }
}

