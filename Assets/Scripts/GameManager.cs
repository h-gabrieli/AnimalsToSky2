using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{   public static GameManager Instance;

    // Pontuação
    public Text[] pointsText = new Text[2];
    static public Text[] text = new Text[2];
    static public int[] points = new int[2];
    public int totalChaves = 10; // Total para vencer

    // Vitória
    public GameObject victoryPanel;
    public TextMeshProUGUI victoryText;

    private void Awake()
    {
        // Singleton
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);

        // Inicializa pontuações
        points[0] = 0;
        points[1] = 0;
        text[0] = pointsText[0];
        text[1] = pointsText[1];

        // Esconde a tela de vitória no começo
        if (victoryPanel != null)
            victoryPanel.SetActive(false);
    }

    // Adiciona ponto a um jogador
    static public void Point(int player)
    {
        points[player]++;
        text[player].text = points[player].ToString() + "/10";

    }

    // Mostra tela de vitória
    public void ShowVictoryScreen(int playerIndex)
    {
        Time.timeScale = 0f; // Pausa o jogo
        victoryPanel.SetActive(true);
        victoryText.text = "Jogador " + (playerIndex + 1) + " venceu!";
    }

    // Botão de nova partida
    public void RestartMatch()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Botão de voltar ao menu
    public void ReturnToMenu()
    {
        Time.timeScale = 1f;
        if (AudioManager.Instance != null)
        {
            Destroy(AudioManager.Instance.gameObject);
        }

        SceneManager.LoadScene("MenuInicial");
   
    }
}   