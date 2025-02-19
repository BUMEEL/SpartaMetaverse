using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneUIManager : MonoBehaviour
{
    public GameObject LoadScenePanel;
    public GameObject ClosetPanel;

    // Start is called before the first frame update
    void Start()
    {
        OpenLoadMiniGameScenePanel(false);
        OpenClosetPanel(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenLoadMiniGameScenePanel(bool Open)
    {
        if (Open)
        {
            LoadScenePanel.SetActive(true);
        }
        else
        {
            LoadScenePanel.SetActive(false);
        }
    }

    public void LoadMiniGameScene()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void OpenClosetPanel(bool Open)
    {
        if (Open)
        {
            ClosetPanel.SetActive(true);
        }
        else
        {
            ClosetPanel.SetActive(false);
        }
    }
}
