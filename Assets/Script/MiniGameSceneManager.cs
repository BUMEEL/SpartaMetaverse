using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        Destroy(GameObject.FindWithTag("Player"));

        YourScore = 0;

        GameObject[] Walls =GameObject.FindGameObjectsWithTag("Point");
        for (int i = 0; i <Walls.Length; i++)
        {
            Destroy(Walls[i]);
        }

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
        Time.timeScale = 1;
        SceneManager.LoadSceneAsync(0);
    }

    public void NewHighScoreCheck()
    {
        if (YourScore > HighScore)
        {
            HighScore = YourScore;
            Debug.Log("New HighScore!!!");
        }
    }
}
