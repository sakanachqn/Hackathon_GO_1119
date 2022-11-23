using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //���E�ړ��̋����w��
    [SerializeField]
    float Move = 2.1f;

    //�ړ����x
    private float MoveSpeed = 1f;

    //�ǂ����Ɉړ����邩�̔���^�O
    private bool isMoveR = false;
    private bool isMoveL = false;

    //�ړ�������^�O
    private bool isMoveNow = false;

    //���݈ʒu�̎擾
    Vector3 nowPos;
    //�ړ���̊m��
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
