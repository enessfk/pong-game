using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HumanRacket : Racket
{

    protected override void Movement()
    {
        float moveAxesValue = Input.GetAxis(AxesName) * moveSpeed;
        rb.velocity = new Vector2(0, moveAxesValue);
    }
}
