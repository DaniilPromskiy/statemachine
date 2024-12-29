using UnityEngine;

public class HighlightState : State
{
    private PlayerCombat playerCombat;

    public HighlightState(PlayerCombat combat)
    {
        playerCombat = combat;
    }

    public override void Enter()
    {
        playerCombat.EnableHighlight();
    }

    public override void Exit()
    {
        playerCombat.DisableHighlight();
    }

    public override void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerCombat.ToggleHighlight();
        }
    }
}