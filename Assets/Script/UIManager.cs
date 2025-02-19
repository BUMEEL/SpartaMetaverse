using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    GameObject GM;

    public GameObject ResultPanel;
    public GameObject Points;

    public GameObject HighScore;
    public GameObject YourScore;

    // Start is called before the first frame update
    void Start()
    {
        GM = GameObject.Find("GM");
        OpenStartPanel();
    }

    // Update is called once per frame
    void Update()
    {
        Points.GetComponent<TextMeshProUGUI>().text = "Score : "+GM.GetComponent<MiniGameSceneManager>().YourScore;
    }

    public void OpenStartPanel()
    {
        Time.timeScale = 0;

        HighScore.GetComponent<TextMeshProUGUI>().text = "High Score : " +  GM.GetComponent<MiniGameSceneManager>().HighScore;
        YourScore.GetComponent<TextMeshProUGUI>().text = "Your Score : " + GM.GetComponent<MiniGameSceneManager>().YourScore;

        ResultPanel.SetActive(true);
    }

    public void ClickStartButton ()
    {
        GM.GetComponent<MiniGameSceneManager>().StartMiniGame();
        ResultPanel.SetActive(false);
    }
}
