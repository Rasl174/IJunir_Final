using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BallMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Player _player;
    [SerializeField] private Racket _racket;
    [SerializeField] private Canvas _restartMenu;

    private Rigidbody2D _ballBody;
    private Vector3 _startVector;
    private Vector3 _startPosition;
    private bool _ballIsMoving = false;

    public bool BallIsMoving => _ballIsMoving;

    private void Start()
    {
        _startPosition = gameObject.transform.position;
        _ballBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(_ballIsMoving == false)
        {
            _startPosition.x = _racket.transform.position.x;
            transform.position = _startPosition;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.TryGetComponent(out Brick brick))
        {
            brick.PlayParticleSystem();
            _player.AddPoints();
            brick.gameObject.SetActive(false);
        }

        if(collision.collider.TryGetComponent(out Floor floor))
        {
            _ballBody.Sleep();
            _ballIsMoving = false;
            gameObject.transform.position = _startPosition;
            _racket.ReturnOnStartPosition();
            _restartMenu.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void StartBallMove()
    {
        _startVector = new Vector3(Random.Range(-1f, 1f), 1f);
        _ballBody.AddForce(_startVector * _speed * Time.deltaTime);
        _ballIsMoving = true;
    }
}
