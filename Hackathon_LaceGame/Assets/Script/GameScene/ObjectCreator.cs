using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCreator : MonoBehaviour
{
    [SerializeField]
    GameObject gobj = null;

    [SerializeField]
    GameObject buffgobj = null;

    private int rndint;
    private int rndlane;
    private int rndlane2;


    private float time;
    private float buff_time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreCount.IsGameStart)
        {
            time += Time.deltaTime;
            buff_time += Time.deltaTime;
            //オブジェクト生成位置決定
            if (time >= 0.7)
            {
                rndlane = Random.Range(1, 5);
                switch (rndlane)
                {
                    case 1:
                        Instantiate(gobj);
                        gobj.transform.position = new Vector3(-4.6f, 6, 0);
                        break;
                    case 2:
                        Instantiate(gobj);
                        gobj.transform.position = new Vector3(-2.3f, 6, 0);
                        break;
                    case 3:
                        Instantiate(gobj);
                        gobj.transform.position = new Vector3(0, 6, 0);
                        break;
                    case 4:
                        Instantiate(gobj);
                        gobj.transform.position = new Vector3(2.3f, 6, 0);
                        break;
                    case 5:
                        Instantiate(gobj);
                        gobj.transform.position = new Vector3(4.6f, 6, 0);
                        break;

                }
                time = 0;
            }

            if (buff_time >= 1.5f)
            {
                rndlane2 = Random.Range(1, 5);
                switch (rndlane2)
                {
                    case 1:
                        Instantiate(buffgobj);
                        buffgobj.transform.position = new Vector3(-4.6f, 6, 0);
                        break;
                    case 2:
                        Instantiate(buffgobj);
                        buffgobj.transform.position = new Vector3(-2.3f, 6, 0);
                        break;
                    case 3:
                        Instantiate(buffgobj);
                        buffgobj.transform.position = new Vector3(0, 6, 0);
                        break;
                    case 4:
                        Instantiate(buffgobj);
                        buffgobj.transform.position = new Vector3(2.3f, 6, 0);
                        break;
                    case 5:
                        Instantiate(buffgobj);
                        buffgobj.transform.position = new Vector3(4.6f, 6, 0);
                        break;

                }
                buff_time = 0;
            }
        }
    }
}
