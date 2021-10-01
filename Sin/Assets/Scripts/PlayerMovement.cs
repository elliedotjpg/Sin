using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private GameManager gameManager = new GameManager();

    public float MovementSpeed = 1;

    private Rigidbody2D _rigidbody;
    private Animator _animator;
    public int Score;

    AudioSource ButtonSFX;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (GameManager.GameState == GameManager.EnumGameState.Playing)
        {
            PlayerInput();
        }
        else
        {
            _rigidbody.velocity = new Vector2(0, 0);
        }
        _animator.SetFloat("Walk", Mathf.Abs(_rigidbody.velocity.x));
    }

    private void PlayerInput()
    {
        transform.parent = null;

        // 
        if (Input.GetKey(KeyCode.S))
        {
            SetMovement(-MovementSpeed, -Mathf.Abs(transform.localScale.x));
        }

        // 
        else if (Input.GetKey(KeyCode.W))
        {
            SetMovement(MovementSpeed, Mathf.Abs(transform.localScale.x));
        }
        else
        {
            _rigidbody.velocity = new Vector2(0, _rigidbody.velocity.y);
        }

        // 
        if (Input.GetKey(KeyCode.D))
        {
            SetMovement(MovementSpeed, Mathf.Abs(transform.localScale.y));
        }

        // 
        else if (Input.GetKey(KeyCode.A))
        {
            SetMovement(-MovementSpeed, -Mathf.Abs(transform.localScale.y));
        }
        else
        {
            _rigidbody.velocity = new Vector2(0, _rigidbody.velocity.x);
        }
    }

    private void SetMovement(float MovementSpeed, float faceDirection)
    {
        _rigidbody.velocity = new Vector2(MovementSpeed, _rigidbody.velocity.y);
        transform.localScale = new Vector3(faceDirection, transform.localScale.y, transform.localScale.z);
    }
}
