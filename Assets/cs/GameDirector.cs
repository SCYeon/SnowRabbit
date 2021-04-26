using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    GameObject player;
    GameObject flag;
    GameObject distance;
    GameObject hpGauge;
    GameObject strawberry;
    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
        this.strawberry = GameObject.Find("StrawberryCount");
        this.hpGauge = GameObject.Find("hpGauge");
    }
    public void DecreaseHP()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
        if(this.hpGauge.GetComponent<Image>().fillAmount == 0)
        {
            Destroy(player);
            SceneManager.LoadScene("GameOverScene");
        }
    }
    public void IncreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount += 0.1f;
    }

    public void countStrawberry(int count)
    {
        this.count += count;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 p1 = this.flag.transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;

        float length = this.flag.transform.position.x - this.player.transform.position.x;
        this.distance.GetComponent<Text>().text = "±ê¹ß±îÁö " + d.ToString("F2") + "m / ";
        this.strawberry.GetComponent<Text>().text = "Ã£Àº µþ±â: " + this.count + "°³ / HP: ";
    }
}
