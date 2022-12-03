using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    [SerializeField]
    GameObject Score_UI = null;

    [SerializeField]
    SoundManager soundManager = null;
    [SerializeField]
    private AudioClip CDSE;
    [SerializeField]
    private AudioClip bgm;

    static public float score;
    static public bool IsGameStart = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(countdown());
        score = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (IsGameStart)
        {
            score += BackGround.speed * GameoverCheck.BuffSpeed * Time.deltaTime;

            Text scoreText = Score_UI.GetComponent<Text>();

            scoreText.text = score.ToString("N0") + "m";
        }

    }

    private IEnumerator countdown()
    {
        soundManager.Play(CDSE);
        yield return new WaitForSeconds(3);
        soundManager.loopPlay(bgm);
        IsGameStart = true;
    }
}
