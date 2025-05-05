using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) // Quando entrar em contato com o Trigger
    {
        if(other.gameObject.CompareTag("Player")) // Se o outro objeto tiver tag Player ele entra aqui
        {
            int _player = other.gameObject.GetComponent<Player>().playerIndex; //Pega o índice do jogador (0 ou 1), através do script Player anexado no jogador
            GameManager.Point(_player);
            Destroy(gameObject); // Quando o Player tocar o objeto destroi
        }
    }

}
