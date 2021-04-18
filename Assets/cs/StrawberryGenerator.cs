using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrawberryGenerator : MonoBehaviour
{
    public GameObject strawberry;
    bool flag = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (flag == true)
        {
            GameObject strawberry1 = Instantiate(strawberry) as GameObject;
            GameObject strawberry2 = Instantiate(strawberry) as GameObject;
            GameObject strawberry3 = Instantiate(strawberry) as GameObject;
            GameObject strawberry4 = Instantiate(strawberry) as GameObject;

            strawberry1.transform.position = new Vector3(-6.4f, 0.14f, 0);
            strawberry2.transform.position = new Vector3(-6.5f, 3.2f, 0);
            strawberry3.transform.position = new Vector3(9.8f, 4.3f, 0);
            strawberry4.transform.position = new Vector3(4.9f, -4.4f, 0);

            flag = false;
        }
    }
}
