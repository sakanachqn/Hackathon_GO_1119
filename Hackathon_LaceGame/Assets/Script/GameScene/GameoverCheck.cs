using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameoverCheck : MonoBehaviour
{
    [SerializeField]
    SoundManager soundManager;
    [SerializeField]
    private AudioClip GOSE;
    [SerializeField]
    private AudioClip BuffSE;

    public static float BuffSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            StartCoroutine(GameOver());
        }
        else if(other.gameObject.tag == "BuffObstacle")
        {
            soundManager.Play(BuffSE);
            BuffSpeed++;
        }
    }

    private IEnumerator GameOver()
    {
        soundManager.Stop();
        soundManager.Play(GOSE);
        ScoreCount.IsGameStart = false;
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("ResultScene");
        
    }
}
