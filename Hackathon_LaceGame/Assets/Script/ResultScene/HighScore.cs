using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    [SerializeField]
    public GameObject highScoreObj = null;

    public float highScoreNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        highScoreNum = PlayerPrefs.GetFloat("Score", 0);
        if(highScoreNum <= ScoreCount.score)
        {
            highScoreNum = ScoreCount.score;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Text highScore_Text = highScoreObj.GetComponent<Text>();

        highScore_Text.text = highScoreNum.ToString("N0") + "m";
    }

    void OnDestroy()
    {
        // ÉXÉRÉAÇï€ë∂
        if(highScoreNum <= ScoreCount.score)
        {
            PlayerPrefs.SetFloat("Score", ScoreCount.score);
            PlayerPrefs.Save();
        }
        else
        {
            PlayerPrefs.SetFloat("Score", highScoreNum);
            PlayerPrefs.Save();
        }
    }
}
