using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // A câmera deve seguir (geralmente o jogador)

    public float smoothSpeed;// Velocidade de suavização do movimento da câmera

    public Vector3 offset;// Deslocamento da posição do alvo (para ajustar a posição da câmera em relação ao jogador)

    void FixedUpdate()// Chamado em intervalos fixos (ideal para cálculos de física ou movimentos suaves)
    {
        if (target != null)// Garante que há um alvo definido
        {
            Vector3 newPosition = target.position + offset;// Calcula a nova posição da câmera baseada na posição do alvo mais o deslocamento

            newPosition.z = transform.position.z;// Mantém a posição Z da câmera (profundidade), útil em jogos 2D

            newPosition.x = transform.position.x;// Mantém a posição X da câmera fixa (se for um jogo com rolagem vertical, por exemplo)

            Vector3 smoothPos = Vector3.Lerp(transform.position, newPosition, smoothSpeed);// Suaviza a transição da posição atual da câmera para a nova posição calculada

            transform.position = smoothPos;// Atualiza a posição da câmera
        }
    }
}
