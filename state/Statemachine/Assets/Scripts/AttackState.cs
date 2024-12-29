using UnityEngine;

public class AttackState : State
{
    private PlayerCombat playerCombat;

    public AttackState(PlayerCombat combat)
    {
        playerCombat = combat;
    }

    public override void Enter()
    {
        
    }

    public override void Exit()
    {
        
    }

    public override void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerCombat.Shoot();
        }
    }
}