using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipeswpan : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject pipe;
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newpipe = Instantiate(pipe);
        newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        Destroy(newpipe, 5);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newpipe,5);
            timer = 0;
        }
        timer += Time.deltaTime;
        if (Score.score >= 20 && Score.score < 41)
        {
            maxTime = 2.3f;
        }
        if (Score.score >= 41 && Score.score < 62)
        {
            maxTime = 2f;
        }
        if (Score.score >= 62 && Score.score < 81)
        {
            maxTime = 1.7f;
        }
        if (Score.score >= 81)
        {
            maxTime = 1.4f;
        }
    }
}
