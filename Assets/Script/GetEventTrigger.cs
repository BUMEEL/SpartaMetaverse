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
                case "MiniGameTrigger":
                    _uimanager.GetComponent<MainSceneUIManager>().OpenLoadMiniGameScenePanel(true);
                    break;

                case "ClosetTrigger":
                    _uimanager.GetComponent<MainSceneUIManager>().OpenClosetPanel(true);
                    break;

                default:
                    Debug.Log("NoCase");
                    break;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        switch (name)
        {
            case "MiniGameTrigger":
                _uimanager.GetComponent<MainSceneUIManager>().OpenLoadMiniGameScenePanel(false);
                break;

            case "ClosetTrigger":
                _uimanager.GetComponent<MainSceneUIManager>().OpenClosetPanel(false);
                break;

            default:
                Debug.Log("NoCase");
                break;
        }
    }
}
