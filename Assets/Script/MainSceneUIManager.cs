using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneUIManager : MonoBehaviour
{
    public GameObject LoadScenePanel;
    public GameObject ClosetPanel;
    public GameObject RidePanel;

    // Start is called before the first frame update
    void Start()
    {
        LoadScenePanel.SetActive(false);
        ClosetPanel.SetActive(false);
        RidePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenLoadMiniGameScenePanel()
    {
        if (!LoadScenePanel.activeSelf)
        {
            string NewBieTXT;
            if (!PlayerPrefs.HasKey("BestScore"))
            {
                Debug.Log("NoKey");
                NewBieTXT = "Do You Wanna Play MiniGames Or Something?";
            }
            else
            {
                Debug.Log("HasKey");
                NewBieTXT = $"Your Best Score is \n{PlayerPrefs.GetInt("BestScore")}\nWanna Record A New Score?";
            }
            LoadScenePanel.SetActive(true);
            LoadScenePanel.GetComponentInChildren<TextMeshProUGUI>().text = NewBieTXT;
        }
        else
        {
            LoadScenePanel.SetActive(false);
        }
    }

    public void LoadMiniGameScene()
    {
        SceneManager.LoadScene(1);
    }

    public void OpenClosetPanel()
    {
        if (!ClosetPanel.activeSelf)
        {
            ClosetPanel.SetActive(true);
        }
        else
        {
            ClosetPanel.SetActive(false);
        }
    }
    public void OpenRidePanel()
    {
        if (!RidePanel.activeSelf)
        {
            RidePanel.SetActive(true);
        }
        else
        {
            RidePanel.SetActive(false);
        }
    }

    public void DeleteScore()
    {
        PlayerPrefs.DeleteAll();
    }
}
