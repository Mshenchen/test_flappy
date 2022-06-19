using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rangeappear : MonoBehaviour
{
    public float creatTime = 5f;
    public GameObject coller;
    // Start is called before the first frame update
    void Start()
    {
        creatTime = Random.Range(10, 20);
    }

    // Update is called once per frame
    void Update()
    {
        creatTime -= Time.deltaTime;

        if (creatTime <= 0)    //如果倒计时为0 的时候
        {
            creatTime = Random.Range(10, 15);     //随机3到9秒内
            GameObject colls = Instantiate(coller);
            colls.transform.position = new Vector3(Random.Range(3.27f, 4.71f), Random.Range(-0.15f, 0.25f), 0);
            Destroy(colls, 6);
        }
    }
    
}
