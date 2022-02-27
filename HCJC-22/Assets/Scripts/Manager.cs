using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    private Emotions _emotions;
    public GameObject MainMenu;
    public GameObject FinishMenuPanel;
    public GameObject LoseText;
    public GameObject WonText;
    public Movement _movement;

    public void StartGame()
    {
        MainMenu.SetActive(false);
        _movement.StartRun = true;
    }

    public void FinishMenu()
    {
        FinishMenuPanel.SetActive(true);
        if (_emotions.joys > _emotions.sadness)
        {
            WonText.SetActive(true);
        }
        else if (_emotions.sadness > _emotions.joys)
        {
            LoseText.SetActive(true);
        }
    }
}
