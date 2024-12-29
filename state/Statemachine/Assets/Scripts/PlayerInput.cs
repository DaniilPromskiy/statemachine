using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public string horizontalAxis = "Horizontal";
    public string verticalAxis = "Vertical";
    public KeyCode shootKey = KeyCode.Space;

    public Vector2 GetMovementInput()
    {
        return new Vector2(Input.GetAxis(horizontalAxis), Input.GetAxis(verticalAxis));
    }

    public bool GetShootInput()
    {
        return Input.GetKeyDown(shootKey);
    }
}