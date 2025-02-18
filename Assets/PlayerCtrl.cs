using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerCtrl : MonoBehaviour
{
    public float Speed = 10.0f;

    public int NomSpeed = 3;
    public int RunSpeed = 5;

    public GameObject Bullets;
    public GameObject FirePosition;

    public float Health;

    private void Start()
    {
        InvokeRepeating("GetHealth", 0, 10);
    }

    // Update is called once per frame
    void Update()
    {
        float playerXMove = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        float playeYMove = Input.GetAxis("Vertical") * Speed * Time.deltaTime;


        if (Input.GetKey(KeyCode.LeftShift))
        {
            Speed = RunSpeed;
        }
        else
        {
            Speed = NomSpeed;
        }        
        this.transform.Translate(new Vector2(playerXMove, playeYMove));


        if (playerXMove > 0)
        {
            GetComponentInChildren<SpriteRenderer>().flipX = false;
        }

        else if (playerXMove<0)
        {
            GetComponentInChildren<SpriteRenderer>().flipX = true;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Speed = 100.0f;
        }
    }

    void Fire ()
    {
        Instantiate(Bullets, FirePosition.transform.position, FirePosition.transform.rotation);
    }

    public void GetDamage(float BossBulletDamage)
    {
        Health -= BossBulletDamage;
        if (Health <=0)
        {
            Time.timeScale = 0;
        }
    }
    void GetHealth()
    {
        if (Health<=3)
        Health++;
    }
}
