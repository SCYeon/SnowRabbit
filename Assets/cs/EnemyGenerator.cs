using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject snake;
    bool flag = true;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(flag == true)
        {
            GameObject snake1 = Instantiate(snake) as GameObject;
            GameObject snake2 = Instantiate(snake) as GameObject;
            GameObject snake3 = Instantiate(snake) as GameObject;

            snake1.transform.position = new Vector3(-4.8f, 0.19f, 0);
            snake2.transform.position = new Vector3(-7.1f, 3.0f, 0);
            snake3.transform.position = new Vector3(0.1f, 2.6f, 0);

            flag = false;
        }
    }
}
