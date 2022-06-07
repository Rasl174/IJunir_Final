using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private Racket _racket;
    [SerializeField] private BallMover _ball;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            _racket.MoveLeft();
        }
        if (Input.GetKey(KeyCode.D))
        {
            _racket.MoveRight();
        }
        if (Input.GetKey(KeyCode.Space) && _ball.BallIsMoving == false)
        {
            _ball.StartBallMove();
        }
    }
}
