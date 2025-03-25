using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movementHorizontal = Input.GetAxis("Horizontal");
        rb2d.velocity = new Vector2(movementHorizontal * speed,rb2d.velocity.y);
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            rb2d.AddForce(new Vector2(rb2d.velocity.x, jumpForce), ForceMode2D.Impulse);
        }
    }
}
