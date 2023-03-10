using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelselect : MonoBehaviour
{
    public Button  level02Button, level03Button;
    int levelPassed;
    // Start is called before the first frame update
    void Start()
    {
        levelPassed = PlayerPrefs.GetInt("LevelPassed");
        level02Button.interactable = false;
        level03Button.interactable = false;

        switch (levelPassed)
        {
            case 1:
                level02Button.interactable = true;
                break;
            case 2:
                level02Button.interactable = true;
                level03Button.interactable = true;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void levelToLoad(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void resetPlayerPref()
    {
        level02Button.interactable = false;
        level03Button.interactable = false;
        PlayerPrefs.DeleteKey("LevelPassed");
    }
    public void loadLevel2()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void loadLevel3()
    {
        SceneManager.LoadScene("Level 3");
    }

    public void loadLevel4()
    {
        SceneManager.LoadScene("Level 4");
    }

    public void loadlevel5()
    {
        SceneManager.LoadScene("Level 5");
    }

    public void loadlevel1()
    {
        SceneManager.LoadScene("Level 1");
    }
}
