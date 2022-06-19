using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public Gamemanger gamemanger;
    public float velocity = 1;
    private Rigidbody2D rb;
    public AudioSource jumpAudio,hitAudio,get;
    public float angle = 1f;
    public Transform birdtran;
    public Collider2D pipe;
    public Rigidbody2D boom;
    public Transform barrelend;
    public float force;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            if (gamemanger.isGame==false) return;
            jumpAudio.Play();
            rb.velocity = Vector2.up * velocity;
        }
        birdtran.transform.DORotateQuaternion(Quaternion.Euler(0, 0, rb.velocity.y * angle), 0.3f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Pipe")
        {
            hitAudio.Play();
            gamemanger.Gameover();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "collection")
        {
            get.Play();
            Destroy(collision.gameObject);
            hit();
            Invoke("hit", 1.5f);
        }
    }
    void hit()
    {
        Rigidbody2D projectboom;
            projectboom = Instantiate(boom, barrelend.position, barrelend.rotation) as Rigidbody2D;
            projectboom.AddForce(barrelend.right * force);
    }
}
