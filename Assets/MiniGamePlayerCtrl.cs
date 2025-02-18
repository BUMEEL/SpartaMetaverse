using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGamePlayerCtrl : MonoBehaviour
{
    bool Flying = false;
    float speed;
    Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position,transform.right,speed * Time.deltaTime);
        if (Input.GetButtonDown("Jump"))
        {
            if (rb.gravityScale >= 1)
            {
                rb.gravityScale = -1;
            }
            else
            {
                rb.gravityScale = 1;
            }
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Wall"))
        {
            Debug.Log ("Collision Has Met");
        }
    }
}
