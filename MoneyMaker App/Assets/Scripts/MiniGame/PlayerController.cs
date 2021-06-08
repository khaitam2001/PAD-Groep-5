using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public float JumpForce = 10;
    public float MoveSpeed = 10;
    public float JumpPowerUpAmount = 2;

    public LayerMask GroundLayer;
    public float GroundCheckDistance = 1f;

    private Rigidbody2D rb;
    private SpriteRenderer image;
    private bool grounded;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        image = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            rb.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }

        rb.AddForce(new Vector2(Input.GetAxis("Horizontal") * MoveSpeed * Time.deltaTime, 0));

        var horizontalVelocity = rb.velocity.x;

        if (horizontalVelocity > 0.1)
        {
            image.flipX = true;
        }
        else if(horizontalVelocity < -0.1)
        {
            image.flipX = false;
        }
    }

    void LateUpdate()
    {
        if (Physics2D.Raycast(transform.position, Vector2.down, GroundCheckDistance, GroundLayer))
        {
            grounded = true;
        }
        else
        {
            grounded = false;
        }
    }

    public void JumpUpgrade()
    {
        JumpForce += JumpPowerUpAmount;
    }
}
