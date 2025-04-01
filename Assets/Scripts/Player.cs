using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int jumpCount = 0;

    public bool isGrounded = false;
    public float speed;
    public float jumpForce;
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalValue = Input.GetAxis("Horizontal");
        if (horizontalValue < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        rb2d.velocity = new Vector2(horizontalValue * speed, rb2d.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded || Input.GetKeyDown(KeyCode.Space) && jumpCount <= 2)
        {
            rb2d.AddForce(new Vector2(rb2d.velocity.x, jumpForce), ForceMode2D.Impulse);
            jumpCount++;

        }

    }
    //Verifica quando está em colisão com algum objeto de certa TAG ou tipo, etc.
    void OnCollisionStay2D(Collision2D other)
    {
        //Valida o que está encostando -> quando está no chão
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            if (jumpCount >= 2)
            {
                jumpCount = 0;
            }
        }

    }
    //Verifica quando sai de certa colisão.
    void OnCollisionExit2D(Collision2D collision)
    {
        //Valida o que está encostando -> quando sai do chão.
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
