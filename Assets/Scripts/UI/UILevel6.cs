using Data;
using Grid.GridData;
using Grid.GridFillers;
using Grid.GridItems;
using LevelSolver;
using PlayerLevel;
using ResultPanel;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

namespace UI
{
    public class UILevel6 : AbstractUILevel
    {
        
        [SerializeField] private GridFillerClickable playerGridFiller;
        [FormerlySerializedAs("previousGridFiller")] [SerializeField] private GridFillerPreview gridFillerPreview;

        [SerializeField] private TextMeshProUGUI iterationText;
        [SerializeField] private GameObject previousIterationButton;
        [SerializeField] private GameObject previousIterationPanel;

        [SerializeField] private GameObject timerAreaPanel;

        public override void InitializeOnAwake()
        {
            levelGenerator = new LevelGenerator();
            levelSolver = new LevelSolverLevel6();
            playerLevel = new PlayerLevel6();
            
            previousIterationPanel.SetActive(false);
            previousIterationButton.SetActive(false);
            timerAreaPanel.SetActive(true);
            
            playerGridFiller.Initialize(gridSize, this);
            gridFillerPreview.Initialize(gridSize, this);
            
            levelGenerator.Initialize(gridSize);
            levelSolver.Initialize(levelGenerator.Grid, this);
            GetPlayerLevel().Initialize(levelGenerator.Grid, this);

            playerGridFiller.UpdateGridByPlayerLevelGrid(GetPlayerLevel());
            
            UpdateIterationNumber();
        }

        public override void OnButtonGridItemClicked(GridItem gridItem)
        {
            if (isCheckButtonPressed)
            {
                playerGridFiller.UpdateGridByExplanationMistakeResultAnswer(gridItem, GetLevelSolver());
                UIResultPanel6 resultUI = resultPanel.GetComponent<UIResultPanel6>();

                GridItemData correctData = GetLevelSolver().GetGridItemDataAtPoint(gridItem.Point);
                GridItemData playerData = GetPlayerLevel().GetGritItemDataAtPoint(gridItem.Point);
                resultUI.InitializeErrorDescriptionPanel(correctData, playerData);
            }
            else
            {
                GetPlayerLevel().OnGridItemClicked(gridItem);
            }
        }

        public override void OnButtonCheckResultClicked()
        {
            isCheckButtonPressed = true;
            
            previousIterationPanel.SetActive(false);
            timerAreaPanel.SetActive(false);
            playerGridFiller.UpdateGridByCheckResultAnswer(GetPlayerLevel());
            informationPanel.SetActive(false);
            Reference.reference.UIController.SetActiveBottomPanel(false);
            resultPanel.SetActive(true);
            UIResultPanel6 resultUI = resultPanel.GetComponent<UIResultPanel6>();
            bool isGridFilledCorrect = GetPlayerLevel().IsGridFilledCorrect();

            resultUI.InitializeStartPanel(isGridFilledCorrect? ResultStatus.Correct : ResultStatus.WrongValue);

        }

        public override void OnButtonBackExplanationPanelClicked()
        {
            OnButtonCheckResultClicked();
        }
        
        public void OnButtonEditPreviousStepClicked()
        {
            playerGridFiller.UpdateGridByPreviousGridValues(GetPlayerLevel().GetPreviousGridItemStatus());
            GetPlayerLevel().OnButtonEditPreviousClicked();

            if (GetPlayerLevel().PlayerIterations.Count <= 1)
            {
                previousIterationPanel.SetActive(false);
                previousIterationButton.SetActive(false);
            }
            else
            {
                gridFillerPreview.UpdatePreviousStepGrid();
            }
            UpdateIterationNumber();
        }
        
        public void OnButtonNextIterationClicked()
        {
            playerGridFiller.UpdateGridByPlayerLevelGrid(GetPlayerLevel());
            GetPlayerLevel().SaveIteration();
            
            if (GetPlayerLevel().PlayerIterations.Count > 1)
            {
                previousIterationPanel.SetActive(true);
                previousIterationButton.SetActive(true);
                gridFillerPreview.UpdatePreviousStepGrid();
            }

            UpdateIterationNumber();
        }

        private void UpdateIterationNumber()
        {
            iterationText.text = $"{(((PlayerLevel6)PlayerLevel).GetCurrentIteration() +1),0:D2}";
        }
        
        private PlayerLevel6 GetPlayerLevel() => (PlayerLevel6) playerLevel;
        private LevelSolverLevel6 GetLevelSolver() => (LevelSolverLevel6) levelSolver;
    }
}