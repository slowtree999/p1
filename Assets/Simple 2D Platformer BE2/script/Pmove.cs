using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pmove : MonoBehaviour
{
    public float imput;
    public float maxSpeed;
    public bool down;
    Rigidbody2D rigid;
    SpriteRenderer spriteRenderer;
    Animator anim;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();

    }

    void Update()
    {
        imput = Input.GetAxisRaw("Horizontal");
        down = Input.GetButtonDown("Horizontal");
        //stop speed

        if (Input.GetButtonUp("Horizontal"))
        {
        
            rigid.velocity = new Vector2(rigid.velocity.normalized.x * 0.5f , rigid.velocity.y);


        }

        //Direction Sprite 캐릭 방향전환

        if (Input.GetAxisRaw("Horizontal") != 0)
            spriteRenderer.flipX = Input.GetAxisRaw("Horizontal") == -1;

        if (Mathf.Abs(rigid.velocity.x) < 0.3f)
            anim.SetBool("isWalk", false);

        else
            anim.SetBool("isWalk", true);



    }

    void FixedUpdate()
    {
        //move speed
        float h = Input.GetAxisRaw("Horizontal");

        rigid.AddForce(Vector2.right * h, ForceMode2D.Impulse);


        //max speed

        if (rigid.velocity.x > maxSpeed)            //right max speed
            rigid.velocity = new Vector2 (maxSpeed, rigid.velocity.y);

        else if (rigid.velocity.x < maxSpeed * (-1))       //left max speed
            rigid.velocity = new Vector2 (maxSpeed * (-1), rigid.velocity.y);
    }
}
