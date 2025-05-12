using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;// Permite usar elementos da UI, sprit -> coração


public class PlayerHealth : MonoBehaviour
{
    public Image[] hearts; // Vetor com as imagens dos corações na tela (3 imagens no inspector)
    public int maxLives = 3; // Número máximo de vidas
    private int currentLives; // Vidas atuais do jogador
    private Vector3 startPosition;  // Posição inicial do jogador na cena

    // Start is called before the first frame update
    void Start()
    {
        currentLives = maxLives; // Começa com o número máximo de vidas
        startPosition = transform.position; // salva posição inicial do jogador
    }

    public void TakeDamage()// Esta função é chamada quando o jogador toma dano
    {
        if (currentLives <= 0)// Se já estiver sem vidas, não faz nada
            return;

            currentLives--;// Tira uma vida

        if (hearts[currentLives] != null) // Verifica se o coração da vida atual existe
            hearts[currentLives].enabled = false; // esconde um coração

        if (currentLives <= 0)// Se acabou todas as vidas...
        {
            RestartPlayer();// Reposiciona o jogador e reinicia vidas
        }
    }

    void RestartPlayer()// Função para reiniciar a vida do jogador
    {
        currentLives = maxLives;// Restaura o total de vidas

        // Mostra novamente todos os corações
        for (int i = 0; i < hearts.Length; i++)
        {
            if (hearts[i] != null)
                hearts[i].enabled = true;
        }

        transform.position = startPosition;// Move o jogador de volta para onde ele começou
    }

}
