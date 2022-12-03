using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //¶‰EˆÚ“®‚Ì‹——£Žw’è
    [SerializeField]
    float Move = 2.3f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreCount.IsGameStart)
        {
            PLMove();
            if (GameoverCheck.BuffSpeed >= 1)
            {
                GameoverCheck.BuffSpeed -= Time.deltaTime / 2;
            }
        }


    }

    void PLMove()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += new Vector3(Move, 0, 0);
            if(transform.position.x > 4.6)
            {
                transform.position = new Vector3(4.6f, -4, 0);
            }
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position -= new Vector3(Move, 0, 0);
        }
        if (transform.position.x < -4.6)
        {
            transform.position = new Vector3(-4.6f, -4, 0);
        }
    }

}
