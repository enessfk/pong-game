using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Racket : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed;
    public string AxesName;
    public int Score { get; private set; }
    public Text scoreText;

    void FixedUpdate()
    {
        Movement();

        #region AnotherMovementOption
        //if (Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow))
        //{
        //    rb.transform.position += Vector3.up;
        //}

        //if (Input.GetKey("s") || Input.GetKey(KeyCode.DownArrow))
        //{
        //    rb.transform.position += Vector3.down;
        //}
        #endregion

    }

    protected abstract void Movement();

    public void GetScore(){
        Score++;
        scoreText.text = Score.ToString();
    }

}
