using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text[] pointsText = new Text[2]; // Array público de Text para exibir a pontuação dos dois jogadores (configurado no Inspector do Unity)
    static public Text[] text = new Text[2];// Array estático de Text para acesso global à pontuação exibida
    static public int[] points = new int [2]; // Quantidade total de "chaves" no jogo (pode ser usada como objetivo do jogo, por exemplo)
    public int totalChaves; // Método chamado automaticamente pelo Unity antes do Start()

    void Awake()
    {   // Inicializa a pontuação dos dois jogadores com zero
        points[0] = 0;
        points[1] = 0;
        // Associa os objetos Text públicos (definidos no Inspector) aos textos estáticos usados globalmente
       text[0] = pointsText[0];
       text[1] = pointsText[1];
    }
    
    // Método estático chamado para adicionar ponto a um jogador
    // player: índice do jogador (0 ou 1)
    static public void Point(int player)// visibilidade/retorno/nome do método(parametro)

    {
        // Incrementa a pontuação do jogador especificado
        points[player]++;
        // Atualiza o texto da pontuação na tela, formatado como "X/10"
        text[player].text = (points[player].ToString() + "/10"); // Texto de pontuação
    }


}
