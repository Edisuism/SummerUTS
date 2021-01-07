using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public int health;

    [SerializeField] private float baseSpeed;

    private Vector2 moveDirection;
    private Vector2 translation;
    private float _speed;
    private Vector2 _input;

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
    }


    private void UpdateInput()
    {
        _input.x = Input.GetAxisRaw("Horizontal");
        _input.y = Input.GetAxisRaw("Vertical");
    }

   
}
