using UnityEngine;
using UnityEngine.UI;

public class GameStateController : StateController
{
    [SerializeField] private LevelManager levelManager;
    [SerializeField] private ActionSelectorController playerActionSelector;
    [SerializeField] private ButtonEndController buttonEndController;
    [SerializeField] private PlayerButtonBehaviour[] playerButtons;
    [SerializeField] private ActionSelectorController enemyActionSelector;
    [SerializeField] private CommandProcessor playerProcessor;
    [SerializeField] private CommandProcessor enemyProcessor;
    [SerializeField] private HealthBehaviour enemyHealth;

    private IState levelSetupState;
    private IState playerTurnState;
    private IState enemyTurnState;
    private IState turnResolutionState;
    private IState levelEndState;

    private void Awake()
    {
        levelSetupState = new LevelSetupState(this, levelManager);
        playerTurnState = new PlayerTurnState(this, playerActionSelector, buttonEndController, playerButtons);
        enemyTurnState = new EnemyTurnState(this, enemyActionSelector);
        turnResolutionState = new TurnResolutionState(this, playerProcessor, enemyProcessor,
            playerActionSelector, enemyActionSelector);
        levelEndState = new LevelEndState(this, enemyHealth);

        states.Add(typeof(LevelSetupState), levelSetupState);
        states.Add(typeof(PlayerTurnState), playerTurnState);
        states.Add(typeof(EnemyTurnState), enemyTurnState);
        states.Add(typeof(TurnResolutionState), turnResolutionState);
        states.Add(typeof(LevelEndState), levelEndState);
    }

    private void Start()
    {
        // Initial state
        SwitchState<LevelSetupState>();
    }
}