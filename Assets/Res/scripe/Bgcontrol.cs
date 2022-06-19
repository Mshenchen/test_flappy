using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bgcontrol : MonoBehaviour
{
    Vector3 startPos;
    public float speed=0.3f;
    public float placement;
    public Gamemanger gamemanger;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gamemanger.isMove) return;
        if (transform.position.x < -2.6f + placement)
        {
            transform.position = startPos;
        }
        transform.Translate(speed, 0, 0);
    }
}

