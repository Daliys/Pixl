using Grid;
using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private ClickableGridFiller playerGridFiller;
    [SerializeField] private PreviousGridFiller previousGridFiller;

    [SerializeField] private Point gridSize;
    [SerializeField] private TextMeshProUGUI iterationText;
    [SerializeField] private GameObject previousIterationButton;
    [SerializeField] private GameObject previousIterationPanel;
    
    [SerializeField] private GameObject resultPanel;
    [SerializeField] private GameObject timerAreaPanel;
    [SerializeField] private GameObject informationPanel;
    
    private LevelGenerator levelGenerator;
    private LevelSolver levelSolver;
    private PlayerLevel playerLevel;

    private void Awake()
    {
        levelGenerator = new LevelGenerator();
        levelSolver = new Level2();
        playerLevel = new PlayerLevel();

        playerGridFiller.Initialize(gridSize, this);
        previousGridFiller.Initialize(gridSize, this);

        Initialize();
    }

    private void Initialize()
    {
        previousIterationPanel.SetActive(false);
        previousIterationButton.SetActive(false);

        levelGenerator.Initialize(gridSize);
        levelSolver.Initialize(levelGenerator.Grid);
        playerLevel.Initialize(levelGenerator.Grid, levelSolver);

        playerGridFiller.UpdateGridByPlayerLevelGrid();
        UpdateIterationNumber();
    }

    public void OnButtonNextIterationClicked()
    {
        playerGridFiller.UpdateGridByPlayerLevelGrid();
        playerLevel.SaveIteration();
        
        //for debug
        
        /*
        print("CurrentIter " + playerLevel.GetCurrentIteration());
        previousIterationPanel.SetActive(true);
        previousGridFiller.UpdateByCorrectAnswer();
        */
        
        if (playerLevel.PlayerIterations.Count > 1)
        {
            previousIterationPanel.SetActive(true);
            previousIterationButton.SetActive(true);
            previousGridFiller.UpdatePreviousStepGrid();
        }
        
        UpdateIterationNumber();
    }

    public void OnButtonCheckResultClicked()
    {
        previousIterationPanel.SetActive(false);
        playerGridFiller.UpdateGridByResultValue();
        
        
        resultPanel.GetComponent<ResultUI>().InitializeResultPanel(playerLevel.IsResultCorrect);
        
        SetActivePanels(false);
    }

    public void NewGame()
    {
        levelGenerator.ClearGrid();
        levelSolver.ClearGrid();
        playerLevel.ClearGrid();

        SetActivePanels(true);
        Initialize();
    }

    private void SetActivePanels(bool isActive)
    {
        timerAreaPanel.SetActive(isActive);
        informationPanel.SetActive(isActive);
        resultPanel.SetActive(!isActive);
    }
    
    
    public void OnButtonMainMenuClicked()
    {
        Reference.reference.MainMenuCanvas.gameObject.SetActive(true);
        Reference.reference.MainMenuUI.OpenMainMenuPanel();
        Reference.reference.GameCanvas.gameObject.SetActive(false);
    }

    public void OnButtonEditPreviousStepClicked()
    {
        playerGridFiller.UpdateGridByPreviousGridValues();
        playerLevel.OnButtonEditPreviousClicked();

        if (playerLevel.PlayerIterations.Count <= 1)
        {
            previousIterationPanel.SetActive(false);
            previousIterationButton.SetActive(false);
        }
        else
        {
            previousGridFiller.UpdatePreviousStepGrid();
        }
        UpdateIterationNumber();
    }

    private void UpdateIterationNumber()
    {
        iterationText.text = $"{playerLevel.GetCurrentIteration(),0:D2}";
    }

    public PlayerLevel PlayerLevel => playerLevel;

    public LevelGenerator LevelGenerator => levelGenerator;

    public LevelSolver LevelSolver => levelSolver;
}