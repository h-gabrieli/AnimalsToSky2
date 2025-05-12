using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public void Play()// Método chamado quando o jogador clica no botão "Play"
    {
        SceneManager.LoadScene("Jogo");// Carrega a cena chamada "Jogo", iniciando o gameplay
    }

    public void Exit()// Método chamado quando o jogador clica no botão "Exit"
    {
        Debug.Log("Saiu do jogo");// Mostra uma mensagem no console da Unity (útil durante o desenvolvimento)
        Application.Quit();// Encerra o aplicativo (funciona em builds, não no editor)
    }
}
