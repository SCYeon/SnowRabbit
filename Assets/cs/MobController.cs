using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;
    bool flag = false;
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        int key = 0;

        if (transform.position.x > -6 || transform.position.x < -3.5)
        {
            if (flag == false)
            {
                transform.Translate( -0.01f, 0, 0);
                key = -4;
            }
            else if (flag == true)
            {
                transform.Translate( 0.01f, 0, 0);
                key = 4;
            }
        }
        if (transform.position.x <= -6 || transform.position.x >= -3.5)
        {
            if (flag == false)
            {
                flag = true;
            }
            else if (flag == true)
            {
                flag = false;
            }
            transform.localScale = new Vector3(key, 4, 1);
        }
//Ãæµ¹
        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.3f;
        float r2 = 0.3f;

        if (d < r1 + r2)
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHP();

            Vector3 playerPos = this.player.transform.position;
            this.player.transform.Translate(playerPos.x+5.0f, playerPos.y, 0);
        }
    }
}
