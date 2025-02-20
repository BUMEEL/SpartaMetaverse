using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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

    public void SetRGB ()
    {
        float Rvalue = GameObject.Find("RBar").GetComponent<Slider>().value;
        float Gvalue = GameObject.Find("GBar").GetComponent<Slider>().value;
        float Bvalue = GameObject.Find("BBar").GetComponent<Slider>().value;
        GameObject.Find("Player").GetComponentInChildren<SpriteRenderer>().color = new Color(Rvalue *255, Gvalue*255, Bvalue * 255,255);
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
