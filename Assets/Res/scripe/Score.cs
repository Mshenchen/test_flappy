using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public static int count = 0;
    //public Animator disapper;
    //public Animator disapper2;
    void Start()
    {
        score = 0;
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();
        //if (Score.count == 3)
        //{
        //    disapper.SetBool("appear", false);
        //}
        //if (Score.count == 6)
        //{
        //    disapper2.SetBool("bg_2", false);
        //}
    }
}
