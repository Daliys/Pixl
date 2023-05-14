using Grid.GridData;
using Grid.GridItems;
using LevelSolver;
using PlayerLevel;
using UI;

namespace Grid.GridFillers
{
    public class GridFillerClickableWithText : GridFiller
    {
        private GridItemClickableWithText selectedGridItem = null;
     
        protected override void InitializeGridItem(GridItem gridItem, Point point)
        {
            gridItem.Initialize(point, this);
        }

        public void UpdateGridByCheckResultAnswer()
        {
            UpdateGridBy(GetPlayerLevel().GetResultDataForUpdateCell);
        }

        public void UpdateGridByExplanationMistakeResultAnswer(GridItem gridItem)
        {
   
            GridItemData[,] data = GetSolver().GetGridForResultExplanationPanel(gridItem.Point);
            UpdateGridBy(data);
        }

        public void UpdateGridByPlayerGrid()
        {
            UpdateGridBy(GetPlayerLevel().GetPlayerDataForUpdateCell);
        }

        public void OnChildButtonClicked(GridItemClickable gridItem)
        {
            if (!((UILevel1)uiLevel).IsCheckButtonPressed)
            {
                if (selectedGridItem == gridItem)
                {
                    selectedGridItem = null;
                }
                else
                {
                    selectedGridItem = (GridItemClickableWithText)gridItem;
                }
            }

            ((UILevel1)uiLevel).OnButtonItemClicked(gridItem);
        }

        public void UpdateSelectedGridItem(string text)
        {
            selectedGridItem.UpdateText(text);
        }
    
        
        private LevelSolverLevel1 GetSolver() =>  (LevelSolverLevel1)uiLevel.LevelSolver;
        private PlayerLevel1 GetPlayerLevel() => (PlayerLevel1)uiLevel.PlayerLevel;
        public GridItemClickableWithText SelectedGridItem => selectedGridItem;

        public void SetSelectedGridItem(GridItemClickableWithText gridItem)
        {
            selectedGridItem = gridItem;
        }

    }
}