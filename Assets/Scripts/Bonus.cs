using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    public EnnemiBdion myEnnemy;
    public Rigidbody2D rgbd;
    public Player player;
    private int limTime = 1500;
    public int time = 0;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        time += 1;
        if (time >= limTime)
        {
            time = 0;
            Destroy(gameObject);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer != 3)
        {
            player.nbBonus += 1;
            Destroy(gameObject);
        }
    }
}
