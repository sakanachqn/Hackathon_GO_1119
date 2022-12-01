using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCreator : MonoBehaviour
{
    [SerializeField]
    GameObject gobj = null;

    private int rndint;
    private int rndlane;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rndint = Random.Range(0, 500);
        if (rndint == 1)
        {
            rndlane = Random.Range(1, 5);
            switch(rndlane)
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
        }
    }
}
