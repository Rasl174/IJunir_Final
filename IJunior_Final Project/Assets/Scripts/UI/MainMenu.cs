using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Canvas _mainMenu;

    private void Start()
    {
        Time.timeScale = 0;
    }

    public void GameStart()
    {
        Time.timeScale = 1;
        _mainMenu.gameObject.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
