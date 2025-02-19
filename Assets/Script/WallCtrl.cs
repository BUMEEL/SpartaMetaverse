using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCtrl : MonoBehaviour
{
    public float Wallspeed;
    public GameObject GM;

    // Start is called before the first frame update
    void Start()
    {
        Wallspeed = GameObject.Find("GM").GetComponent<MiniGameSceneManager>().Speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2 (transform.position.x - Wallspeed * Time.deltaTime, transform.position.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Enter");
        Debug.Log(collision.tag);

        if (collision.CompareTag("WallBorder"))
        {
            Debug.Log("It Was WallBorder");

            Debug.Log("Random Position End");

            GameObject.Find("GM").GetComponent<MiniGameSceneManager>().InsWalls(2);

            Destroy(gameObject);
        }
    }
}
