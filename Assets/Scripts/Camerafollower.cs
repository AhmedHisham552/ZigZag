using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollower : MonoBehaviour {
    Vector3 offset;
    public GameObject ball;
    public float lerpRate;
    public bool gameOver;
	// Use this for initialization
	void Start () {
        offset = ball.transform.position - transform.position;
        gameOver = false;
    }

    // Update is called once per frame
    void Update () {
        if (!gameOver)
            follow();
    }
    void follow()
    {
        Vector3 pos = transform.position;
        Vector3 targetPos = ball.transform.position - offset;
        pos = Vector3.Lerp(transform.position, targetPos, lerpRate*Time.deltaTime);
        transform.position = pos;

    }
}
