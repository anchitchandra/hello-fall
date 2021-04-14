using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    Rigidbody2D rb;
    float xinput;
    Vector2 pos;

    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mospos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if(mospos.x < 1)
            {
                transform.Translate(-0.1f, 0, 0);
            }
            else if(mospos.x > 1)
            {
                transform.Translate(0.1f, 0, 0);
            }
        }
        pos.x = Mathf.Clamp(pos.x, -2f, +2f);
         
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            score.scorevalue += 5;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "coin")
        {
            score.scorevalue += 10;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "bomb")
        {
            score.scorevalue -= 15;
            Destroy(collision.gameObject);
        }

    }

}
