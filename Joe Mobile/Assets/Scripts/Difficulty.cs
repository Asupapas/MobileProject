using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difficulty : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void easy()
    {
        PlayerPrefs.SetInt("Difficulty", 2);
        PlayerPrefs.SetInt("SharkSpeed", -1);
    }

    public void Normal()
    {
        PlayerPrefs.SetInt("Difficulty", 0);
        PlayerPrefs.SetInt("SharkSpeed", 0);
    }

    public void Hard()
    {
        PlayerPrefs.SetInt("Difficulty", -2);
        PlayerPrefs.SetInt("SharkSpeed", 4);
    }

    public void Hell()
    {
        PlayerPrefs.SetInt("Difficulty", -4);
        PlayerPrefs.SetInt("SharkSpeed", 10);
    }

    public void GodMode()
    {
        PlayerPrefs.SetInt("Difficulty", 9999);
        PlayerPrefs.SetInt("SharkSpeed", 0);
    }
}
