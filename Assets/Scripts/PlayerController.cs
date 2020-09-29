using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;

    public Animator anim;
    public float speed;

    public float jumpforce;

    void Start()
    {

    }
    void FixedUpdate()
    {

        Moventment();
    }
    void Moventment()
    {
        float horizontalmove = Input.GetAxis("Horizontal");
        float facedirection = Input.GetAxisRaw("Horizontal");

        //角色移動
        
            rb.velocity = new Vector2(horizontalmove * speed * Time.deltaTime, rb.velocity.y);
            anim.SetFloat("running",Mathf.Abs(facedirection));
      
        if (facedirection != 0)

        {
            transform.localScale = new Vector3(facedirection, 1, 1);
        }

        //角色跳躍
        if (Input.GetButtonDown("Jump"))

        {
            rb.velocity = new Vector2(rb.velocity.x, jumpforce * Time.deltaTime);
        }
    }
}
