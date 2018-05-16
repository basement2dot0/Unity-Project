using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private float speed;

    public int CircleCount;
    public int SquareCount;
    public int TriangleCount;

    public int Total;
	// Use this for initialization
	void Start () {
        speed = 5.0f;
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x <= -5)
            transform.position = new Vector3(-5, transform.position.y, transform.position.z);
        if (transform.position.x >= 5)
            transform.position = new Vector3(5, transform.position.y, transform.position.z);

        transform.position = new Vector3(transform.position.x + Input.GetAxis("Horizontal"), transform.position.y, transform.position.z);
        
		
	}
}
