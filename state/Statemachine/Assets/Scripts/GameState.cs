public class GameState : State
{
    private PlayerInput playerInput;

    public GameState(PlayerInput input)
    {
        playerInput = input;
    }

    public override void Enter()
    {
        
        playerInput.enabled = true;
    }

    public override void Exit()
    {
        
        playerInput.enabled = false;
    }

    public override void Update()
    {
        
    }
}