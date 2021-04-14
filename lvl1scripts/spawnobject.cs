using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnobject : MonoBehaviour
{
    public GameObject ball;
    public GameObject coin;
    public GameObject bomb;
    public float maxx;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpwanBall", 2f, 1f);
        InvokeRepeating("SpCoin", 15f, 10f);
        InvokeRepeating("SpBomb", 10f, 7f);
    }

    // Update is called once per frame
    void Update()
    {

    }


    void SpwanBall()
    {
        float xinput = Random.Range(-maxx, maxx);
        Vector3 randomcoinspawn = new Vector3(xinput, 7.6f , -0.52f);
        Instantiate(ball, randomcoinspawn, Quaternion.identity);
    }
     void SpCoin()
    {
        float xinput = Random.Range(-maxx, maxx);
        Vector3 randomcoinspawn = new Vector3(xinput, 7.6f, -0.52f);
        Instantiate(coin, randomcoinspawn, Quaternion.identity);
    }
    void SpBomb()
    {
        float xinput = Random.Range(-maxx, maxx);
        Vector3 randomcoinspawn = new Vector3(xinput, 7.6f, -0.52f);
        Instantiate(bomb, randomcoinspawn, Quaternion.identity);
    }




}
