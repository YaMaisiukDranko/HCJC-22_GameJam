using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject MainMenu;
    public Movement _movement;

    public void StartGame()
    {
        MainMenu.SetActive(false);
        _movement.StartRun = true;
    }
}
