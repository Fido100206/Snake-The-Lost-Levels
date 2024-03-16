using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float TimeLeft = 10;

    public Text TimerText;
    public string  gameOverSceneName = "Level 2";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeLeft > 0)
        {
        TimeLeft -= Time.deltaTime;
        updateTimer(TimeLeft);
      
        }

        else
        {
            Debug.Log ("Gane Over");
            TimeLeft= 0;
            LoadGameOverScene();
        }
        
    }

    void updateTimer (float currentTime)
    {

        float minutes = Mathf.FloorToInt (currentTime / 60);
        float seconds = Mathf.FloorToInt (currentTime % 60);

        TimerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
    void LoadGameOverScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(gameOverSceneName);
    }
}
