using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour {
    public float speed = 25;
    public float ratio = 0.1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //transform.position += new Vector3(0.0f, 0.0f, -1 * speed * ratio * Time.deltaTime);
	}
}
