using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool Gameover;
    private void Awake()
    {
        if (instance == null)
            instance = this;
    }
    // Use this for initialization
    void Start()
    {
        Gameover = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GameStart()
    {
        UiManager.instance.GameStart();
        ScoreManager.instance.StartScore();
        GameObject.Find("Platform Spawner").GetComponent<PlatformSpawn>().startSpawning();

    }
    public void GameOver()
    {
        UiManager.instance.GameOver();
        ScoreManager.instance.StopScore();
    }
}
