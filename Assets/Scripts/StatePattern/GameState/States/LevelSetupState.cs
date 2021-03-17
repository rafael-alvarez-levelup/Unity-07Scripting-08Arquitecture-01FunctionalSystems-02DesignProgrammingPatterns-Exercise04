// TODO: Could use update to implement a timer

public class LevelSetupState : State
{
    public LevelSetupState(IStateController controller) : base(controller)
    {
        
    }

    public override void Enter()
    {
        // Implement events or behaviours
        // Suscribe to events

        UnityEngine.Debug.Log($"Enter {typeof(LevelSetupState)}");

        LevelManager.Instance.IncrementLevel();

        // Instantiate new enemy
        UnityEngine.Debug.Log("Instantiate new enemy");

        controller.SwitchState<PlayerTurnState>();
    }

    public override void Exit()
    {
        // Implement events
        // Unsuscribe from events

        UnityEngine.Debug.Log($"Exit {typeof(LevelSetupState)}");
    }
}