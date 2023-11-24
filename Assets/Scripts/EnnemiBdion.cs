using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemiBdion : MonoBehaviour
{
    public ScoreManager myScoreManager;
    public GameObject bonus;
    public int pv;
    private int direction=0;
    private int time = 0;
    private int limTime = 1500;
    public float speed = 0.005f;


    private void Start()
    {
        myScoreManager = FindObjectOfType<ScoreManager>();

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (pv != 0)
        {
            pv -= 1;
        }
        if (pv == 0)
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            myScoreManager.score++;
            GameObject createdBonus = Instantiate(bonus, transform.position, transform.rotation);
            createdBonus.GetComponent<Bonus>().myEnnemy = this;
        }
    }
    private void Update()
    {
        time += 1;
        if (time >= limTime)
        {
            time = 0;
            if (direction == 0)
            {
                direction = 1;
            }
            else if(direction == 1)
            {
                direction = 0;
            }
        }

        if (direction == 0)
        {
            transform.position += Vector3.right*speed;
        }
        if (direction == 1)
        {
            transform.position += Vector3.left*speed;
        }

    }
}