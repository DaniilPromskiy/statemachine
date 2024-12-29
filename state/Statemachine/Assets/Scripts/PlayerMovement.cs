using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private PlayerInput playerInput;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
    }

    private void Update()
    {
        Vector2 movement = playerInput.GetMovementInput();
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}