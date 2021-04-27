using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBulletController : MonoBehaviour
{
    int key = 0; 
    GameObject player;
    float moveSpeed = 30.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
        if (this.player.transform.localScale.x == -1) key = -1;
        else key = 1;
    }

    // Update is called once per frame
    public void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * key * moveSpeed);
    }
}
