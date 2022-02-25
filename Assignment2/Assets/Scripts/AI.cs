using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AI : MonoBehaviour
{
    float speed = 30;
    public GameObject Ball_1;
    public GameObject Ball_2;

    float ball_x = 0;
    float ball_y = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //Console.WriteLine(Math.Sqrt(Math.Pow(5-2,2) + Math.Pow(4-3,2)));
    void Update()
    {
        //float ball_y_1 = Ball_1.transform.position.y;
        //float ball_x_1 = Ball_1.transform.position.x;

        //float ball_x_2 = Ball_2.transform.position.x;
        //float ball_y_2 = Ball_2.transform.position.y;

        float rocket_y = transform.position.y;
        float rocket_x = transform.position.x;

        float rocket_h = GetComponent<BoxCollider2D>().transform.localScale.y;
        float direction;
        if(rocket_x - Ball_1.transform.position.x < rocket_x - Ball_2.transform.position.x)
        {
            ball_x = Ball_1.transform.position.x;
            ball_y = Ball_1.transform.position.y;
        }
        else
        {
            ball_x = Ball_2.transform.position.x;
            ball_y = Ball_2.transform.position.y;
        }

        if(ball_x > 0)
        {
            if(ball_y + rocket_h < rocket_y)
            {
                direction = -1;
            }
            else if(ball_y - rocket_h > rocket_y)
            {
                direction = 1;
            }
            else
            {
                direction = 0;
            }
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, direction) * speed;
        }
        
    }
}
