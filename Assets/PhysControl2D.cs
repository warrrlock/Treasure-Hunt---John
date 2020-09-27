using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PhysControl2D : MonoBehaviour
{
    public SpriteRenderer thisSprite;
    public Rigidbody2D thisRigidbody2D;
    public float force = 15f;
    public float speed = 1f;

    public float gravityInAir;

    public GroundCheck groundCheckScript; //non blue letter = naming that public.

    void Update()
    {
        if (groundCheckScript.isGrounded == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                thisRigidbody2D.AddForce(Vector2.up * force, ForceMode2D.Impulse);
            }
            thisRigidbody2D.gravityScale = 1;
        }

        if (groundCheckScript.isGrounded == false)
        {
            thisRigidbody2D.gravityScale = gravityInAir;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
            

            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);

            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
    }

    // Update is called once per frame
    /*void FixedUpdate()
     {
         if (Input.GetKey(KeyCode.D))
         {

             thisRigidbody2D.AddForce(Vector2.right * force * Time.fixedDeltaTime, ForceMode2D.Impulse);

             if (thisSprite.flipX == true)
             {
                 thisSprite.flipX = false;
             }
         }

         if (Input.GetKey(KeyCode.A))
         {

             thisRigidbody2D.AddForce(Vector2.left * force * Time.fixedDeltaTime, ForceMode2D.Impulse);

             if (thisSprite.flipX == false)
             {
                 thisSprite.flipX = true;
             }
         }
     }*/
}