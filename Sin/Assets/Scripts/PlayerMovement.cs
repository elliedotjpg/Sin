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
        _animator.SetFloat("WalkHorizontal", Mathf.Abs(_rigidbody.velocity.x));
        _animator.SetFloat("WalkVerticalUp", Mathf.Abs(_rigidbody.velocity.y));
        //_animator.SetFloat("WalkVerticalDown", Mathf.Abs(_rigidbody.velocity.y));
        Debug.Log(_rigidbody.velocity);
    }

    private void PlayerInput()
    {
        transform.parent = null;


        // Down
        if (Input.GetKey(KeyCode.S))   
        {
            SetMovement(-MovementSpeed, Mathf.Abs(transform.localScale.x));
        }

        // Up
        else if (Input.GetKey(KeyCode.W))
        {
            SetMovement(MovementSpeed, Mathf.Abs(transform.localScale.x));
        }

        else
        {
            _rigidbody.velocity = new Vector2(0, _rigidbody.velocity.y);

        }


        // Right
        if (Input.GetKey(KeyCode.D))
        {
            SetMovement(MovementSpeed, Mathf.Abs(transform.localScale.y));
        }

        // Left
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
