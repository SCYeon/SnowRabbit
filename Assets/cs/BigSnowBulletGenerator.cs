using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigSnowBulletGenerator : MonoBehaviour
{
    public GameObject SnowBulletPrefab;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("bigPlayer");
    }

    public void BigShot()
    {
        GameObject instance = Instantiate(SnowBulletPrefab) as GameObject;
        instance.transform.position = new Vector3(this.player.transform.position.x, this.player.transform.position.y, 0);
        Destroy(instance, 1.0f);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
