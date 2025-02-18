using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    GameObject GM;

    public GameObject ResultPanel;
    // Start is called before the first frame update
    void Start()
    {
        GM = GameObject.Find("GM");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenStartPanel()
    {
        ResultPanel.SetActive(true);
    }

    public void ClickStartButton ()
    {
        GM.GetComponent<MiniGameSceneManager>().StartMiniGame();
        ResultPanel.SetActive(false);
    }
}
