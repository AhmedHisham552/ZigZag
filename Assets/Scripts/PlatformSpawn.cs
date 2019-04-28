using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawn : MonoBehaviour {
    public GameObject platform;
    public GameObject Diamond;
    float Size;
    Vector3 lastPos;
    public bool gameOver;


	// Use this for initialization
	void Start () {
        lastPos = platform.transform.position;
        Size = platform.transform.localScale.x;
        startSpawning();
	}
    public void startSpawning()
    {
        InvokeRepeating("RandomSpawn", 0f, 0.1f);

    }

    // Update is called once per frame
    void Update () {
        if (GameManager.instance.Gameover==true)
        {
            CancelInvoke("RandomSpawn");
        }
	}
    void RandomSpawn()
    {
        int Rand = Random.Range(0, 6);
        if (Rand <3)
            SpawnX();
        else if (Rand >3)
            SpawnZ();
    }


    void SpawnX()
    {
        Vector3 pos = lastPos;
        pos.x += Size;
        lastPos = pos;
        Instantiate(platform, pos, Quaternion.identity);
        Vector3 diamondpos = pos;
        diamondpos.y += 0.85f;
        int Rand = Random.Range(0, 10);
        if (Rand <= 2)
        {
            Instantiate(Diamond, diamondpos, Diamond.transform.rotation);
        }
    }
    void SpawnZ()
    {
        Vector3 pos = lastPos;
        pos.z += Size;
        lastPos = pos;
        Instantiate(platform, pos, Quaternion.identity);
        Vector3 diamondpos = pos;
        diamondpos.y += 0.85f;
        int Rand = Random.Range(0, 10);
        if (Rand <= 2)
        {
            Instantiate(Diamond, diamondpos, Diamond.transform.rotation);
        }
    }
   
}
