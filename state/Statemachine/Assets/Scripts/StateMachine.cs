using System.Collections.Generic;

public class StateMachine
{
    private State currentState;
    private Dictionary<string, State> states = new Dictionary<string, State>();

    public void AddState(string name, State state)
    {
        states[name] = state;
    }

    public void ChangeState(string newStateName)
    {
        currentState?.Exit();
        currentState = states[newStateName];
        currentState.Enter();
    }

    public void Update()
    {
        currentState?.Update();
    }
}