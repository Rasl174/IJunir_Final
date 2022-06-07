using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private Vector2 _racketPosition;
    private Vector3 _startPosition;
    private float _maxMoveRacket = 7.5f;

    private void Start()
    {
        _startPosition = gameObject.transform.position;
        _racketPosition = gameObject.transform.position;
    }

    private void FixedUpdate()
    {
        gameObject.transform.position = _racketPosition;
    }

    public void MoveLeft()
    {
        _racketPosition.x = Mathf.MoveTowards(_racketPosition.x, -_maxMoveRacket, _moveSpeed * Time.deltaTime);
    }

    public void MoveRight()
    {
        _racketPosition.x = Mathf.MoveTowards(_racketPosition.x, _maxMoveRacket, _moveSpeed * Time.deltaTime);
    }

    public void ReturnOnStartPosition()
    {
        _racketPosition.x = _startPosition.x;
    }
}
