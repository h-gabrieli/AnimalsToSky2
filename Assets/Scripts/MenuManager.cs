using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Jogo");
    }

    public void Exit()
    {
        Debug.Log("Saiu do jogo");
        Application.Quit();
    }
}
