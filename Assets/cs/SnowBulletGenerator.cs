using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBulletGenerator : MonoBehaviour
{
    public GameObject SnowBulletPrefab; 
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    public void Shot(int key)
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
