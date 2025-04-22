using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int jumpCount = 0;

    public bool isGrounded = false;
    public float speed;
    public float jumpForce;

    public int playerIndex = 0;
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalValue = 0f;
        if (playerIndex == 0)
        {
         horizontalValue = Input.GetAxis("Horizontal");
            
        }else
        {
            horizontalValue = Input.GetAxis("HorizontalP2");
        }

        if (horizontalValue < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else if(horizontalValue > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        rb2d.velocity = new Vector2(horizontalValue * speed, rb2d.velocity.y);

        if (playerIndex == 0)
        {
            if (Input.GetKeyDown(KeyCode.Space) && isGrounded && jumpCount <= 2)
            {
                rb2d.AddForce(new Vector2(rb2d.velocity.x, jumpForce), ForceMode2D.Impulse);
                jumpCount++;

            }

        }
        else
        {
            if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded && jumpCount <= 2)
            {
                rb2d.AddForce(new Vector2(rb2d.velocity.x, jumpForce), ForceMode2D.Impulse);
                jumpCount++;

            }
        }
        

    }
    //Verifica quando est� em colis�o com algum objeto de certa TAG ou tipo, etc.
    void OnCollisionStay2D(Collision2D other)
    {
        //Valida o que est� encostando -> quando est� no ch�o
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            jumpCount = 0;
            
            
        }

    }
    //Verifica quando sai de certa colis�o.
    void OnCollisionExit2D(Collision2D collision)
    {
        //Valida o que est� encostando -> quando sai do ch�o.
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
