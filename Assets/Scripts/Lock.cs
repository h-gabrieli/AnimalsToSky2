using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision) //Quando outro objeto entra no trigger da barreira
    {
        if (collision.CompareTag("Player"))// Verifica se quem colidiu tem a tag "Player"
        { 
            PlayerHealth playerHealth = collision.GetComponent<PlayerHealth>();// Pega o script PlayerHealth que está no jogador
            if (playerHealth != null)// Verifica se o jogador tem o script
            {
                playerHealth.TakeDamage(); // Aplica dano ao jogador
            }
        }

    }
}
