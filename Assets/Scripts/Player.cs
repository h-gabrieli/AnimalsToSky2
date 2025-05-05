using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Publico é possivel consigo ver no inspector e puxar em qualquer outro script
    //Private existe apenas neste script -> [SerializeField] private

    public bool isGrounded; // Responde se é verdadeiro ou falso -> verifica se está no chão ou não

    public float speed; // Entrega números quebrados(com virgulas) -> Velocidade dos personagens

    public float jumpForce; // Entrega números quebrados(com virgulas) - > Força dos pulos

    public int playerIndex; // Entrega numeros inteiros -> Filtra o jogador

    private float _horizontalValue; // Movimentação dos players 

    private Rigidbody2D _rb2d; // Aplicar força sobre o player

    void Awake() // Antes do start -> Atribuir valores que não mudam durante o jogo
    {
        _rb2d = GetComponent<Rigidbody2D>(); // Informando qual Rigidbody 
    }

    void Update()// Atualiza uma vez por frame
    {
        
        if (playerIndex == 0) // Se o for player 1 -> Movimenta-se com as A ou D. Se não player 1 -> Movimenta-se com as setas
        {
            _horizontalValue = Input.GetAxis("Horizontal");
            if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
            {
                _rb2d.AddForce(new Vector2(_rb2d.velocity.x, jumpForce), ForceMode2D.Impulse);

            } 
        }else
        {
            _horizontalValue = Input.GetAxis("HorizontalP2");
             if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
            {
                _rb2d.AddForce(new Vector2(_rb2d.velocity.x, jumpForce), ForceMode2D.Impulse);

            }
        }

        if (_horizontalValue < 0) // 
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else if(_horizontalValue > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        _rb2d.velocity = new Vector2(_horizontalValue * speed, _rb2d.velocity.y);

    }
    //Verifica quando estao em colisao com algum objeto de certa TAG ou tipo, etc.
    void OnCollisionStay2D(Collision2D other)
    {
        //Valida o que estao encostando -> quando estao no chao
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;  
            
        }

    }
    //Verifica quando sai de certa colisao.
    void OnCollisionExit2D(Collision2D collision)
    {
        //Valida o que estao encostando -> quando sai do chao.
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
