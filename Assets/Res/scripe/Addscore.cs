using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addscore : MonoBehaviour
{
    // Start is called before the first frame update
    
    private void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.score++;
        Score.count++;
        
    }
    
}
