using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{ 
     void OnTriggerEnter2D(Collider2D other) //Quando outro objeto entra no trigger da porta
    {
        if (other.CompareTag("Player")) // Verifica se o objeto que entrou no trigger tem a tag "Player"
        {
            int playerIndex = other.GetComponent<Player>().playerIndex; //Pega o índice do jogador (0 ou 1), através do script Player anexado no jogador

            if (GameManager.points[playerIndex] == 10) // Verifica se o jogador coletou todas as chaves
            {
                Destroy(other.gameObject); // Se coletou todas as chaves, destrói o player (o jogador "entra na porta")
            }
            
        }
    }
}
