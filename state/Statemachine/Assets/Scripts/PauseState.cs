using UnityEngine;

public class PauseState : State
{
    public override void Enter()
    {
        Time.timeScale = 0; 
    }

    public override void Exit()
    {
        Time.timeScale = 1; 
    }

    public override void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
        }
    }
}