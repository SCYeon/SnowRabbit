using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");    
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = this.player.transform.position;
        if(playerPos.x <= -8.56)
        {
            transform.position = new Vector3(
                   -8.56f, playerPos.y + 0.5f, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(
            playerPos.x, playerPos.y + 0.5f, transform.position.z);
        }
    }
}
