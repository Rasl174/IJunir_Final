using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RestartMenu : MonoBehaviour
{
    [SerializeField] private Canvas _restartMenu;
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _points;
    [SerializeField] private List<GameObject> _bricks;

    private void Update()
    {
        if (gameObject.activeSelf == true)
        {
            _points.text = _player.Points.ToString();
        }
    }

    public void RestartGame()
    {
        foreach (var brick in _bricks)
        {
            brick.gameObject.SetActive(true);
        }

        _player.ResetPoints();
        _restartMenu.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
