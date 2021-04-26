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
        if(playerPos.x < -9.16f || playerPos.x >= 10.0f)
        {
            if(playerPos.x < -9.16f)
            {
                transform.position = new Vector3(
                       -9.1f, playerPos.y + 0.5f, transform.position.z);
            }
            if(playerPos.x >= 10.0f)
            {
                transform.position = new Vector3(
                       10.0f, playerPos.y + 0.5f, transform.position.z);

            }
        }
        else
        {
            transform.position = new Vector3(
                    playerPos.x, playerPos.y + 0.5f, transform.position.z);
        }
    }
}
