using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Points : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _points;

    private void OnEnable()
    {
        _player.PointsChanged += OnPointsChanged;
    }

    private void OnDisable()
    {
        _player.PointsChanged -= OnPointsChanged;
    }

    private void OnPointsChanged(int points)
    {
        _points.text = points.ToString();
    }
}
