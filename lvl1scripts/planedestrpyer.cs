using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planedestrpyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "ball")
        {
            
            Destroy(collision.gameObject);

        }
        else if (collision.gameObject.tag == "coin")
        {
            
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "bomb")
        {

            Destroy(collision.gameObject);
        }
    }
}
