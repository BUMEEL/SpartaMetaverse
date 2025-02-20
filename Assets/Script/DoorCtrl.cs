using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;

public class DoorCtrl : MonoBehaviour
{
    bool CanOpen;
    public GameObject DoorOpenEffect;

    // Start is called before the first frame update
    void Start()
    {
        CanOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (CanOpen && Input.GetKeyDown(KeyCode.F)) // You Can Press "F" To Open these;
        {
            if (DoorOpenEffect != null)
            {
                Destroy(Instantiate(DoorOpenEffect, new Vector2(transform.position.x+ (Random.Range(-1.0f,1.0f)), (transform.position.y + Random.Range(-1.0f,1.0f))), Quaternion.identity), 0.5f);
                Destroy(Instantiate(DoorOpenEffect, new Vector2(transform.position.x + (Random.Range(-1.0f, 1.0f)), (transform.position.y + Random.Range(-1.0f, 1.0f))), Quaternion.identity), 0.5f);
                Destroy(Instantiate(DoorOpenEffect, new Vector2(transform.position.x + (Random.Range(-1.0f, 1.0f)), (transform.position.y + Random.Range(-1.0f, 1.0f))), Quaternion.identity), 0.5f);
                Destroy(Instantiate(DoorOpenEffect, new Vector2(transform.position.x + (Random.Range(-1.0f, 1.0f)), (transform.position.y + Random.Range(-1.0f, 1.0f))), Quaternion.identity), 0.5f);
            }
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            CanOpen = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            CanOpen = false;
        }
    }
}
