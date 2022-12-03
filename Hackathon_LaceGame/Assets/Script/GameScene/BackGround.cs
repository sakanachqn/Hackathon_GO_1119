using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    public static float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreCount.IsGameStart)
        {
            transform.position -= new Vector3(0, Time.deltaTime * speed);

            if (transform.position.y <= -11f)
            {
                transform.position = new Vector3(-0.4f, 8.5f);
            }
        }
    }
}
