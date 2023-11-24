using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int destroyedBullet;
    public GameObject bullet;
    public GameObject spawn;
    public int nbBonus = 0;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (nbBonus < 3)
            {
                GameObject createdBullet = Instantiate(bullet, spawn.transform.position, spawn.transform.rotation);
                createdBullet.GetComponent<Bullet>().myPlayer = this;
            }
            else if (nbBonus > 2 && nbBonus<10)
            {
                GameObject createdBullet = Instantiate(bullet, spawn.transform.position, spawn.transform.rotation);
                createdBullet.GetComponent<Bullet>().myPlayer = this;
                GameObject createdBullet1 = Instantiate(bullet, spawn.transform.position+ new Vector3(1,0,0), spawn.transform.rotation);
                createdBullet1.GetComponent<Bullet>().myPlayer = this;
            }
            else
            {
                GameObject createdBullet = Instantiate(bullet, spawn.transform.position, spawn.transform.rotation);
                createdBullet.GetComponent<Bullet>().myPlayer = this;
                GameObject createdBullet1 = Instantiate(bullet, spawn.transform.position + new Vector3(1, 0, 0), spawn.transform.rotation);
                createdBullet1.GetComponent<Bullet>().myPlayer = this;
                GameObject createdBullet2 = Instantiate(bullet, spawn.transform.position + new Vector3(-1, 0, 0), spawn.transform.rotation);
                createdBullet2.GetComponent<Bullet>().myPlayer = this;
            }

        }
        
    }
}

