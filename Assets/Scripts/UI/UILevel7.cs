using Data;
using Grid.GridData;
using Grid.GridFillers;
using Grid.GridItems;
using LevelSolver;
using PlayerLevel;
using ResultPanel;
using UnityEngine;

namespace UI
{
    public class UILevel7 : AbstractUILevel
    {
        [SerializeField] private GridFillerPreview gridFillerMask;
        [SerializeField] private GridFillerClickable gridFiller;
        [SerializeField] private GameObject informationPanel;
        [SerializeField] private GameObject resultPanel;
        [SerializeField] private GameObject descriptionText;
        
        private bool isCheckButtonPressed;
        
        protected Mask mask;
        
        public override void InitializeOnAwake()
        {
            mask = new Mask();
            Point maskSize = new Point(3, 3);
            mask.InitializeMask(maskSize);
            mask.GenerateRandomMask(Random.Range(3,7));
            
            InitializeBasValues();
            
            gridFillerMask.Initialize(maskSize,this);
            gridFillerMask.UpdateMaskGrid(mask);
            
            levelGenerator.Initialize(gridSize);
            levelSolver.Initialize(levelGenerator.Grid, this);
            playerLevel.Initialize(levelGenerator.Grid, this);

            gridFiller.Initialize(gridSize, this);
            gridFiller.UpdateGridByPlayerLevelGrid(GetPlayerLevel());
           
        }

        protected virtual void InitializeBasValues()
        {
            levelGenerator = new LevelGenerator();
            levelSolver = new LevelSolverLevel7(mask);
            playerLevel = new PlayerLevel7();

        }

        public override void OnButtonGridItemClicked(GridItem gridItem)
        {
            if (isCheckButtonPressed)
            {
                gridFiller.UpdateGridByExplanationMistakeResultAnswer(gridItem, GetLevelSolver());
                UIResultPanel7 resultUI = resultPanel.GetComponent<UIResultPanel7>();

                GridItemData correctData = GetLevelSolver().GetGridItemDataAtPoint(gridItem.Point);
                GridItemData playerData = GetPlayerLevel().GetGritItemDataAtPoint(gridItem.Point);
                resultUI.InitializeErrorDescriptionPanel(correctData, playerData);
            }
            else
            {

                GetPlayerLevel().SetOppositePlayerValueAtPoint(gridItem.Point);
                gridItem.UpdateCellData(GetPlayerLevel().GetGritItemDataAtPoint(gridItem.Point));
            }
        }

        public override void OnButtonCheckResultClicked()
        {
            isCheckButtonPressed = true;
            
            gridFiller.UpdateGridByCheckResultAnswer(GetPlayerLevel());
            informationPanel.SetActive(false);
            Reference.reference.UIController.SetActiveBottomPanel(false);
            resultPanel.SetActive(true);
            descriptionText.SetActive(false);
            UIResultPanel7 resultUI = resultPanel.GetComponent<UIResultPanel7>();
            bool isGridFilledCorrect = GetPlayerLevel().IsGridFilledCorrect();

            resultUI.InitializeStartPanel(isGridFilledCorrect? ResultStatus.Correct : ResultStatus.WrongValue);
        }

        public override void OnButtonBackExplanationPanelClicked()
        {
            OnButtonCheckResultClicked();
        }

        private PlayerLevel7 GetPlayerLevel() => (PlayerLevel7)playerLevel;
        private LevelSolverLevel7 GetLevelSolver() => (LevelSolverLevel7)LevelSolver;
    }
}