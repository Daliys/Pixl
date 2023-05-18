using System.Collections.Generic;
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
    public class UILevel1 : AbstractUILevel
    {
        [SerializeField] private GridFillerClickableWithText gridFiller;
        [SerializeField] private GameObject popUpScrollingPanel;
        [SerializeField] private GameObject informationPanel;
        [SerializeField] private GameObject resultPanel;
        
        private PopUpScrollingPanel popUpScrollingPanelClass;
        private bool isCheckButtonPressed;
        
        public override void InitializeOnAwake()
        {
            popUpScrollingPanelClass = popUpScrollingPanel.GetComponent<PopUpScrollingPanel>();

            InitializeBasValues();
            
            gridFiller.Initialize(gridSize, this);
            
            levelGenerator.Initialize(gridSize);
            levelSolver.Initialize(levelGenerator.Grid, this);
            GetPlayerLevel().Initialize(levelGenerator.Grid, this);
            
            gridFiller.UpdateGridByPlayerGrid(GetPlayerLevel());

        }

        protected virtual void InitializeBasValues()
        {
            levelGenerator = new LevelGenerator();
            levelSolver = new LevelSolverLevel1();
            playerLevel = new PlayerLevel1();
        }

        public override void OnButtonGridItemClicked(GridItem gridItem)
        {
            if (isCheckButtonPressed)
            {
                gridFiller.UpdateGridByExplanationMistakeResultAnswer(gridItem);
                UIResultPanel1 resultUI = resultPanel.GetComponent<UIResultPanel1>();

                GridItemData correctData = GetLevelSolver().GetGridItemDataAtPoint(gridItem.Point);
                GridItemData playerData = GetPlayerLevel().GetGritItemDataAtPoint(gridItem.Point);
                resultUI.InitializeErrorDescriptionPanel(correctData, playerData);
            }
            else
            {
                OnButtonItemClickedInGame(gridItem);
            }
        }

        private void OnButtonItemClickedInGame(GridItem gridItem)
        {
            bool isActive = gridFiller.SelectedGridItem != null;
            popUpScrollingPanel.SetActive(isActive);
            Reference.reference.UIController.SetActiveBottomPanel(!isActive);
            popUpScrollingPanelClass.OnGridItemClicked(gridItem);
            gridFiller.UpdateGridByPlayerGrid(GetPlayerLevel());
        }

        public override void OnButtonCheckResultClicked()
        {
            isCheckButtonPressed = true;
            
            gridFiller.UpdateGridByCheckResultAnswer();
            informationPanel.SetActive(false);
            Reference.reference.UIController.SetActiveBottomPanel(false);
            resultPanel.SetActive(true);
            UIResultPanel1 resultUI = resultPanel.GetComponent<UIResultPanel1>();
            bool isGridFilledCorrect = GetPlayerLevel().IsGridFilledCorrect();

            resultUI.InitializeStartPanel(isGridFilledCorrect? ResultStatus.Correct : ResultStatus.WrongValue);
        }

        public override void OnButtonBackExplanationPanelClicked()
        {
            OnButtonCheckResultClicked();
        }

        public void OnButtonScrollingBackClicked()
        {
            gridFiller.SetSelectedGridItem(null);
            gridFiller.UpdateGridByPlayerGrid(GetPlayerLevel());
            popUpScrollingPanel.SetActive(false);
            Reference.reference.UIController.SetActiveBottomPanel(true);
        }

        public void OnButtonScrollingElementClicked(IrrationalNumber number)
        {
            Point point = gridFiller.SelectedGridItem.Point;
            GetPlayerLevel().SetGridValue(point, number);
            gridFiller.UpdateSelectedGridItem(number.ToString());
        }

        public virtual List<IrrationalNumber> GetAvailableValues()
        {
            return AvailableValuesForLevel1.AvailableValue;
        }

        public bool IsCheckButtonPressed => isCheckButtonPressed;

        private PlayerLevel1 GetPlayerLevel() => (PlayerLevel1) playerLevel;
        private LevelSolverLevel1 GetLevelSolver() => (LevelSolverLevel1) levelSolver;
        
        public GridFillerClickableWithText GridFiller => gridFiller;
    }
}
