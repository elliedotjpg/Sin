using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private GameManager gameManager = new GameManager();

    public float MovementSpeed = 1f;

    public Rigidbody2D rb;
    public Animator _animator;

    Vector2 movement;

    //AudioSource ButtonSFX;

    private void StartGame()
    {
        if (GameManager.GameState == GameManager.EnumGameState.Playing)
        {
            FixedUpdate();
        }
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        _animator.SetFloat("WalkHorizontalRight", movement.x);
        _animator.SetFloat("WalkHorizontalLeft", -movement.x);
        _animator.SetFloat("WalkVerticalDown", -movement.y);
        _animator.SetFloat("WalkVerticalUp", movement.y);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * MovementSpeed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("DoorCollider"))
        {
            Debug.Log("Collided with " + collision.gameObject.name);
            //SceneManager.LoadScene(0);
        }
    }
}
