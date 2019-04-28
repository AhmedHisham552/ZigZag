using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondBehaviour : MonoBehaviour {
    public GameObject diamond;
    public GameObject particle;
    
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Ball")

        Destroy(transform.gameObject,0f);

    }
}
