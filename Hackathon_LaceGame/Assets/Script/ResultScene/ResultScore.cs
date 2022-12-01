using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultScore : MonoBehaviour
{
    [SerializeField]
    GameObject ResScore = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text res_score = ResScore.GetComponent<Text>();

        res_score.text = ScoreCount.score.ToString("N0") + "m!";
    }
}
