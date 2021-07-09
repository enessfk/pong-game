using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketAI : Racket
{
    public Transform ball;
    protected override void Movement()
    {
        float distance = Mathf.Abs(ball.position.y - transform.position.y);
        if (distance > 3)
        {
            if (ball.position.y > transform.position.y)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * moveSpeed;
            }

            if (ball.position.y < transform.position.y)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1) * moveSpeed;
            }
        }

    }

}
