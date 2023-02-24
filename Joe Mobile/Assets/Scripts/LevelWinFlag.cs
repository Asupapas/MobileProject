using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelWinFlag : MonoBehaviour
{
    int sceneIndex, levelPassed;
    private int nextSceneToLoad;
    // Start is called before the first frame update
    void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        levelPassed = PlayerPrefs.GetInt("LevelPassed");
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (sceneIndex == 4)
        {
            SceneManager.LoadScene("WinScreen");
        }
        else
        {
            if (levelPassed < sceneIndex)
            {
                PlayerPrefs.SetInt("LevelPassed", sceneIndex);
                SceneManager.LoadScene(nextSceneToLoad);
            }
            else
            {
                SceneManager.LoadScene(nextSceneToLoad);
            }
        }

    }
}
