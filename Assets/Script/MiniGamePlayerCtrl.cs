using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGamePlayerCtrl : MonoBehaviour
{
    float speed;
    Rigidbody2D rb;

    public float GS;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = GS;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, transform.right, speed * Time.deltaTime);
        if (Input.GetButtonDown("Jump"))
        {
            if (rb.gravityScale >= 1)
            {
                rb.gravityScale = -GS;
            }
            else
            {
                rb.gravityScale = GS;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Debug.Log("Collision Has Met");
            Time.timeScale = Mathf.Lerp(1, 0, 5);
            GameObject.Find("GM").GetComponent<MiniGameSceneManager>().NewHighScoreCheck();
            GameObject.Find("UIManager").GetComponent<UIManager>().OpenStartPanel();
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Point"))
        {
            Debug.Log("Player Get The Point");
            if (GameObject.Find( "GM" ) != null)
            {
                GameObject.Find("GM").GetComponent<MiniGameSceneManager>().YourScore += 1;
            }
        }
    }
}
