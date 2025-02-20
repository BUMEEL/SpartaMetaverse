using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public float Speed = 10.0f;

    public int NomSpeed = 3;
    public int RunSpeed = 5;

    public float Health;

    public bool IsRiding;
    public int _RidingIndex;

    private void Start()
    {
        IsRiding = false;
        if (PlayerPrefs.HasKey("PlayerRValue"))
        {
            GameObject.Find("Player").GetComponentInChildren<SpriteRenderer>().color = new Color(PlayerPrefs.GetFloat("PlayerRValue"), PlayerPrefs.GetFloat("PlayerGValue"), PlayerPrefs.GetFloat("PlayerBValue"));
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (IsRiding) // Just Build ...
        {
            //Speed = GetComponent<RideData>()._RidingIndex.
        }
        else
        {
            if (Input.GetKey(KeyCode.LeftShift)) //Sprint
            {
                Speed = RunSpeed;
            }
            else
            {
                Speed = NomSpeed;
            }
        }
        float playerXMove = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        float playeYMove = Input.GetAxis("Vertical") * Speed * Time.deltaTime;


        if (playerXMove != 0 || playeYMove != 0)
        {
            this.transform.Translate(new Vector2(playerXMove, playeYMove));
            GetComponentInChildren<Animator>().SetBool("IsMove", true);

            if (playerXMove != 0)
            {
                if (playerXMove > 0)
                {
                    GetComponentInChildren<SpriteRenderer>().flipX = false;
                }
                else if (playerXMove < 0)
                {
                    GetComponentInChildren<SpriteRenderer>().flipX = true;
                }
            }
        }
        else
        {
            GetComponentInChildren<Animator>().SetBool("IsMove", false);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            // Fire();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Speed = 100.0f;
        }
    }

    public void LateUpdate()
    {
        
    }

    public void CallRide(int RideIndex)
    {

    }
}
