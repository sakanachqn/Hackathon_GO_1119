using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //左右移動の距離指定
    [SerializeField]
    float Move = 2.1f;

    //移動速度
    private float MoveSpeed = 1f;

    //どっちに移動するかの判定タグ
    private bool isMoveR = false;
    private bool isMoveL = false;

    //移動中判定タグ
    private bool isMoveNow = false;

    //現在位置の取得
    Vector3 nowPos;
    //移動先の確定
    Vector3 nextPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        getKey();
        playerMove();
    }

    void getKey()
    {
        if (false == isMoveNow)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                nowPos = transform.position;
                nextPos = nowPos - new Vector3(Move, 0, 0);
                isMoveL = true;
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                nowPos = transform.position;
                nextPos = nowPos + new Vector3(-Move, 0, 0);
                isMoveR = true;
            }
        }
    }

    void playerMove()
    {
        if(isMoveR)
        {
            isMoveNow = true;
            if (transform.position.x != nextPos.x)
            {
                transform.position = transform.position + new Vector3(Move * MoveSpeed * Time.deltaTime, 0, 0);
            }
            else if(transform.position.x <= nextPos.x)
            {
                isMoveR = false;
                isMoveNow = false;
            }
        }
        else if(isMoveL)
        {
            isMoveNow = true;
            if (transform.position.x != nextPos.x)
            {
                transform.position = transform.position + new Vector3(-Move * MoveSpeed * Time.deltaTime, 0, 0);
            }
            else if (transform.position.x <= nextPos.x)
            {
                isMoveR = false;
                isMoveNow = false;
            }
        }
    }
}
