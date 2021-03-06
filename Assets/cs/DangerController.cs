using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DangerController : MonoBehaviour
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
        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.3f;
        float r2 = 0.5f;

        if(d < r1 + r2)
        {
            Destroy(player);
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
