using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingDirector : MonoBehaviour
{
    GameObject ending;
    // Start is called before the first frame update
    void Start()
    {
        this.ending = GameObject.Find("Ending");
    }

    // Update is called once per frame
    void Update()
    {
        this.ending.GetComponent<Text>().text = "Game Clear!! \n���䳢�� ������ ���������� ���ƽ��ϴ�! \n\n>>Click<<";
    }
}
