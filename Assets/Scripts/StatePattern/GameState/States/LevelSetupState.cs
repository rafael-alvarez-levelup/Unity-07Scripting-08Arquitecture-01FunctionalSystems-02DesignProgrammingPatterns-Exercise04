// TODO: Could use update to implement a timer

public class LevelSetupState : State
{
    private readonly IIncrementLevel levelIncrementer;

    public LevelSetupState(IStateController controller, IIncrementLevel levelIncrementer) : base(controller)
    {
        this.levelIncrementer = levelIncrementer;
    }

    public override void Enter()
    {
        // Implement events or behaviours
        // Suscribe to events

        UnityEngine.Debug.Log($"Enter {typeof(LevelSetupState)}");

        levelIncrementer.IncrementLevel();

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