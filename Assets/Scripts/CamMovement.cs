using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour {

    public GameObject player;
    public float offset = 3;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
       
            transform.position = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z - offset);


    }
}
