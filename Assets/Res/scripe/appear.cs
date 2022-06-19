using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appear : MonoBehaviour
{
    public GameObject gameobject;
    public Animator disapper;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Score.count == 21)
        {
            disapper.SetBool("appear", false);
        }
        if (Score.count == 42)
        {
            disapper.SetBool("bg_2", false);
        }
        if (Score.count == 63)
        {
            disapper.SetBool("bg_3", false);
        }
        if (Score.count == 81)
        {
            disapper.SetBool("bg_4", false);
        }
        
    }
    void Targetdisappear()
    {
        gameobject.SetActive(false);
    }
}
