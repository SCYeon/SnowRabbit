using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;
    bool flag = false;
    GameObject player;
    float start = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
        this.player = GameObject.Find("player");

        this.start = transform.position.x;
    }

    void Hit(bool flags)
    {
        //Ãæµ¹
        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 0.5f;
        float hit = 0;

        if (d < r1 + r2)
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHP();

            Vector2 playerPos = this.player.transform.position;
            if (flag == true)
            {
                hit = playerPos.x - 0.02f;
            }
            else if (flag == false)
            {
                hit = playerPos.x + 0.02f;
            }
            this.player.transform.Translate(hit, playerPos.y, 0);
        }
    }
    // Update is called once per frame
    void Update()
    {
        int key = 0;
        float direction = 0;

                if (transform.position.x > start - 1.7 || transform.position.x < start + 1.4)
                {
                    if (flag == false)
                    {
                        direction = - 0.01f;
                        key = -4;
                        Hit(flag);
                    }
                    else if (flag == true)
                    {
                        direction = 0.01f;
                        key = 4;
                        Hit(flag);
                    }
                }
                if (transform.position.x <= start - 1.7 || transform.position.x >= start + 1.4)
                {
                    if (flag == false)
                    {
                        flag = true;
                        direction = 0.01f;
                     }
                    else if (flag == true)
                    {
                        flag = false;
                        direction = -0.01f;
                    }
                    transform.localScale = new Vector3(key, 4, 1);
                }
        transform.Translate(direction, 0, 0);

    }
}
