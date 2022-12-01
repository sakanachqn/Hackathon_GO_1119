using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    [SerializeField]
    GameObject Score_UI = null;

    static public float score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score += BackGround.speed * Time.deltaTime;

        Text scoreText = Score_UI.GetComponent<Text>();

        scoreText.text = score.ToString("N0") + "m";

    }
}
