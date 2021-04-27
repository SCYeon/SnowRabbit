using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigSnowBulletController : MonoBehaviour
{
    int key = 0;
    GameObject bigPlayer;
    float moveSpeed = 30.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.bigPlayer = GameObject.Find("bigPlayer");
        if (this.bigPlayer.transform.localScale.x == -2) key = -1;
        else key = 1;
    }

    // Update is called once per frame
    public void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * key * moveSpeed);
    }
}
