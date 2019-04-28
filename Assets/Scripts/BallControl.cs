using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {
    [SerializeField]
    float speed;
    Rigidbody rb;
    bool started;
    GameObject diamond;
    public GameObject particle;
    bool gameOver;
    private void Awake()
    {
        rb = GetComponent<Rigidbody> ();
    }
    // Use this for initialization
    void Start () {
        started = false;
        gameOver = false;
	}

    // Update is called once per frame
    private void Update()
    {
        if (!started)
        {
            if (Input.GetButtonDown("Jump"))
            {
                rb.velocity = new Vector3(speed, 0, 0);
                started = true;
                GameManager.instance.GameStart();
            }
        }
        Debug.DrawRay(transform.position, Vector3.down, Color.cyan);
       if (!Physics.Raycast(transform.position,Vector3.down,1f))
        {
            gameOver = true;
            rb.velocity = new Vector3(0, -30,0);
            Camera.main.GetComponent<Camerafollower>().gameOver= true;
            GameManager.instance.GameOver();
        }
        if (Input.GetButtonDown("Jump") && !gameOver)
            switchDirection();
    }
    void switchDirection () {
        if (rb.velocity.z > 0)
            rb.velocity = new Vector3(speed, 0, 0);
        else if (rb.velocity.x > 0)
            rb.velocity= new Vector3 (0,0,speed);
		
	}
   
}
