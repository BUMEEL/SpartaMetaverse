using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainSceneUIManager : MonoBehaviour
{
    public GameObject LoadScenePanel; //Loading MiniGame Panel
    public GameObject ClosetPanel; // Set RGB of Player's Sprite Panel
    public GameObject RidePanel; // No time for Dev this

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Player").GetComponentInChildren<SpriteRenderer>().color = new Color(PlayerPrefs.GetFloat("PlayerRValue"), PlayerPrefs.GetFloat("PlayerGValue"), PlayerPrefs.GetFloat("PlayerBValue"));

        LoadScenePanel.SetActive(false);
        ClosetPanel.SetActive(false);
        RidePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenLoadMiniGameScenePanel() // Literally...
    {
        if (!LoadScenePanel.activeSelf)
        {
            string NewBieTXT;
            if (!PlayerPrefs.HasKey("BestScore")) // if Player have been playing this minigame
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

    public void SetRGB() //Set Player's RGB In PlayerPrefabs
    {
        float Rvalue = GameObject.Find("RBar").GetComponent<Slider>().value;
        float Gvalue = GameObject.Find("GBar").GetComponent<Slider>().value;
        float Bvalue = GameObject.Find("BBar").GetComponent<Slider>().value;
        GameObject.Find("Player").GetComponentInChildren<SpriteRenderer>().color = new Color(Rvalue * 255, Gvalue * 255, Bvalue * 255, 255);

        PlayerPrefs.SetFloat("PlayerRValue", Rvalue * 255);
        PlayerPrefs.SetFloat("PlayerGValue", Rvalue * 255);
        PlayerPrefs.SetFloat("PlayerBValue", Rvalue * 255);
    }

    public void OpenRidePanel() // No time for dev this
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

    public void DeleteScore() //delete the Score Recs in the Player's Prefabs
    {
        PlayerPrefs.DeleteAll();
    }
}
