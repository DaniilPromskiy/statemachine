using UnityEngine;

public class TransparencyState : State
{
    private PlayerCombat playerCombat;

    public TransparencyState(PlayerCombat combat)
    {
        playerCombat = combat;
    }

    public override void Enter()
    {
        playerCombat.SetTransparency(true);
    }

    public override void Exit()
    {
        playerCombat.SetTransparency(false);
    }

    public override void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerCombat.ToggleTransparency();
        }
    }
}
