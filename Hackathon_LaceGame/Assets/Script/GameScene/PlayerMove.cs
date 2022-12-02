using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //���E�ړ��̋����w��
    [SerializeField]
    float Move = 2.1f;

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
