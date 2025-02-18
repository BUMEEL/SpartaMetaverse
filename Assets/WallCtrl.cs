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
}
