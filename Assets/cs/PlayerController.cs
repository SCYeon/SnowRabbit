using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;
    int trigger;
    float jumpForce = 580.0f;
    float walkForce = 30.0f;
    float maxWalkSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && this.rigid2D.velocity.y == 0)
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }

        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        if(speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }

        if(key != 0)
        {
            transform.localScale = new Vector3(key, 1, 0);
        }

        this.animator.speed = speedx / 2.0f;

        if (Input.GetKeyDown(KeyCode.Z))
        {
            GameObject bullet = GameObject.Find("SnowBulletGenerator");
            bullet.GetComponent<SnowBulletGenerator>().Shot();
        }

        if (transform.position.y < -10)
        {
            SceneManager.LoadScene("GameOverScene");
        }

        this.trigger = GameObject.Find("GameDirector").GetComponent<GameDirector>().count;
        }
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(trigger == 0)
        {
            if (other.gameObject.tag == "Finish")
            {
                Debug.Log("??");
                SceneManager.LoadScene("EndScene");
            }
        }
    }
}
