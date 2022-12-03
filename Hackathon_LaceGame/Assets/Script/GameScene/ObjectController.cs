using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{

    public static bool IsDestroy = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreCount.IsGameStart)
        {
            transform.position -= new Vector3(0, BackGround.speed * GameoverCheck.BuffSpeed * Time.deltaTime, 0);

            if (transform.position.y < -5)
            {
                Destroy(this.gameObject);
            }
        }

        if(IsDestroy)
        {
            Destroy(this.gameObject);
        }
    }
}
