using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{ 
     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Player playerScript = other.GetComponent<Player>();
            int playerIndex = playerScript.playerIndex;

            if (GameManager.points[playerIndex] >= 10)
            {
                Destroy(other.gameObject); // Remove o jogador (entrou na porta)
                GameManager.Instance.ShowVictoryScreen(playerIndex); // Mostra tela de vitória
            }
        }
    }
}
