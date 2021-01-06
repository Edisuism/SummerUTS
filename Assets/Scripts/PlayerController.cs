using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public int health;

    [SerializeField] private float baseSpeed;
    [SerializeField] private Animator animator;
    [SerializeField] private SpriteRenderer spriteRenderer;

    private Vector2 moveDirection;
    private Vector2 translation;
    private float _speed;
    private Vector2 _input;
    private static readonly int MoveBool = Animator.StringToHash("isMoving");

    private void Start()
    {

    }

    private void Update()
    {
        // Calculate current movement speed.
        _speed = baseSpeed;

        // Movement
        UpdateInput();
        moveDirection = _input.normalized;
        translation = moveDirection * (_speed * Time.deltaTime);
        transform.Translate(translation);
       
        /*
        // Animation
        bool isMoving = translation.magnitude >= 0.01f;
        animator.SetBool(MoveBool, isMoving);

        if (isMoving && translation.x != 0)
        {
            spriteRenderer.flipX = translation.x < 0;
        }
        */
    }


    private void UpdateInput()
    {
        _input.x = Input.GetAxisRaw("Horizontal");
        _input.y = Input.GetAxisRaw("Vertical");
    }

   
}
