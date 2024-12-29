using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    private StateMachine stateMachine;
    private PlayerInput playerInput;
    private PlayerCombat playerCombat;

    private void Awake()
    {
        stateMachine = new StateMachine();
        playerInput = GetComponent<PlayerInput>();
        playerCombat = GetComponent<PlayerCombat>();

        
        stateMachine.AddState("Game", new GameState(playerInput));
        stateMachine.AddState("Pause", new PauseState());
        stateMachine.AddState("Final", new FinalState(playerCombat));
    }

    private void Update()
    {
        stateMachine.Update();

        if (Input.GetKeyDown(KeyCode.Return))
        {
            stateMachine.ChangeState("Game");
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            stateMachine.ChangeState("Final");
        }
    }
}