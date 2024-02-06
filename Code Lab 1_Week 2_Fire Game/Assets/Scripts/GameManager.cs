using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score = 0;

    public int targetScore = 5;

    public TextMeshProUGUI scoreText;

    private void Awake()
    {
        // occurs before the first frame, where singleton should go or it could fire before it should have disappeared such as initialization code and run and then screw up the other singleton by waiting for the first frame
        if (instance == null) // if the instance variable has not been set yet
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else //if there is already a singleton of this type
        {
            Destroy(gameObject);
        }

    }


    // Update is called once per frame
    void Update()
    {

        scoreText.text = "Score: " + score;

        //when score reaches target score, we go to the next level
        if (score == targetScore)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            targetScore = Mathf.RoundToInt(targetScore + targetScore * 1.5f);
            /*
            if (SceneManager.GetActiveScene().name == "Level1")
            {
                SceneManager.LoadScene("Level2");
                targetScore *= Mathf.RoundToInt(1.5f);
            }

            if (SceneManager.GetActiveScene().name == "Level2")
            {
                SceneManager.LoadScene("Level3");
                targetScore *= Mathf.RoundToInt(1.5f);
            }
            */
        }

    }
}
