using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstSnowGenerator : MonoBehaviour
{
    public GameObject firstSnowPrefab;
    float span = 1.0f;
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(firstSnowPrefab) as GameObject;
            int px = Random.Range(-10, 11);
            go.transform.position = new Vector3(px, 7, 0);
        }
    }
}
