using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetEventTrigger : MonoBehaviour
{
    GameObject _uimanager;

    // Start is called before the first frame update
    void Start()
    {
        _uimanager = GameObject.Find("UIManager");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            switch (name)
            {
                case "MiniGameTrigger": // to MiniGame
                    _uimanager.GetComponent<MainSceneUIManager>().OpenLoadMiniGameScenePanel();
                    break;

                case "ClosetTrigger": // To Closet
                    _uimanager.GetComponent<MainSceneUIManager>().OpenClosetPanel();
                    break;

                default:
                    Debug.Log("NoCase");
                    break;
            }
        }
    }
}
