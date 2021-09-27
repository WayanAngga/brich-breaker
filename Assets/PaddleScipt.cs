using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScipt : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float horizontal = Input.GetAxis ("Hoizontal");

        transform.Translate (Vector2.right * horizontal * Time.deltaTime * speed);
	}
}
