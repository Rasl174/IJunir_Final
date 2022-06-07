using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    private int _points = 0;

    public int Points => _points;

    public event UnityAction<int> PointsChanged;

    public void AddPoints()
    {
        _points++;
        PointsChanged?.Invoke(_points);
    }

    public void ResetPoints()
    {
        _points = 0;
        PointsChanged?.Invoke(_points);
    }
}
