using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private ParticleSystem _particleSystem;

    private void Start()
    {
        _spriteRenderer.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1);
    }

    public void PlayParticleSystem()
    {
        _particleSystem.startColor = _spriteRenderer.color;
        Instantiate(_particleSystem, gameObject.transform.position, Quaternion.identity);
    }
}
