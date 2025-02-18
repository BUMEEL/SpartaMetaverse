using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEditor.SceneManagement;

public class MiniGameSceneManager : MonoBehaviour
{
    public float Speed;
    public GameObject Walls;

    public int HighScore;
    public int YourScore;

    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void InsWalls(float Xpos)
    {
        float ramdomY = Random.Range(-3, 3);
        Instantiate(Walls, new Vector2(Xpos * 10.0f, ramdomY), Quaternion.identity);
    }

    public void StartMiniGame()
    {
        GameObject[] Walls =GameObject.FindGameObjectsWithTag("Point");
        Destroy(GameObject.FindWithTag("Player"));

        for (int i = 0; i <Walls.Length; i++)
        {
            Destroy(Walls[i]);
        }
        YourScore = 0;
        for (int i = 0; i < 4; i++)
        {
            InsWalls(i);
        }
        Player.transform.position = new Vector2(-5.0f, 0);
        Time.timeScale = 1;
        Instantiate(Player, new Vector2(-5.0f, 0), Quaternion.identity);
    }

    public void PauseMiniGame()
    {
        if (Time.timeScale != 0)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    public void EndMiniGame()
    {
        Time.timeScale = 0;
        GameObject.Find("UIManager").GetComponent<UIManager>().OpenStartPanel();
    }

    public void NewHighScore()
    {
        if (HighScore < YourScore)
        {
            HighScore = YourScore;
            Debug.Log("New HighScore!!!");
        }
    }
}
