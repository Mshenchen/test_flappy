using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if (Score.score >=20&&Score.score<41)
        {
            speed = 1.2f;
        }
        if (Score.score >= 41 && Score.score < 62)
        {
            speed = 1.3f;
        }
        if (Score.score >= 62 && Score.score < 81)
        {
            speed = 1.4f;
        }
        if (Score.score >= 81)
        {
            speed = 1.5f;
        }
    }
}
