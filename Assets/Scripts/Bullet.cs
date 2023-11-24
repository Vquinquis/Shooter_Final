using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Player myPlayer;
    private Rigidbody2D rgbd;
    public int speed;
    private int limTime= 1500;
    public int time = 0;
    // Start is called before the first frame update
    void Start()
    {
        rgbd = gameObject.GetComponent<Rigidbody2D>();
        rgbd.velocity = Vector3.up*speed;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        myPlayer.destroyedBullet++;
        Destroy(gameObject);
    }

    void Update()
    {
        time += 1;
        if (time >= limTime)
        {
            time = 0;
            Destroy(gameObject);
        }

    }

}

