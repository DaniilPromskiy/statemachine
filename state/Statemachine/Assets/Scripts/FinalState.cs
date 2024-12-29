using UnityEngine;

public class FinalState : State
{
    private PlayerCombat playerCombat;

    public FinalState(PlayerCombat combat)
    {
        playerCombat = combat;
    }

    public override void Enter()
    {
        playerCombat.SetTransparency(false); 
        
    }

    public override void Exit()
    {
        
    }

    public override void Update()
    {
        
    }
}
