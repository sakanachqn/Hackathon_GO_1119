using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    [SerializeField]
    SoundManager soundManager;
    [SerializeField]
    private AudioClip clickSE;

    private bool IsStartGame = false;
    private bool NowScenChange = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    public void Onclick()
    {
        StartCoroutine(clickcoroutine());
        IsStartGame = true;
    }

    private IEnumerator clickcoroutine()
    {
        if (IsStartGame == false)
        {
            soundManager.Play(clickSE);
            yield return new WaitForSeconds(3);
            IsStartGame = false;
            SceneManager.LoadScene("GameScene");
        }
    }
}
