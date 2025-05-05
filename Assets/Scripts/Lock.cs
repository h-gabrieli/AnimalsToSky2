using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision) //Quando outro objeto entra no trigger da barreira
    {
        
        if (collision.gameObject.CompareTag("Player"))// Verifica se o objeto que entrou na colisão tem a tag "Player"
        {
            Destroy(collision.gameObject); // Destroi o objeto do player (faz ele desaparecer da cena)
        }
    }
}
