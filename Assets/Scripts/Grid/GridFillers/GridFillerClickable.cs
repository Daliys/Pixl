using Grid.GridItems;

namespace Grid.GridFillers
{
    public class GridFillerClickable : GridFiller
    {
        protected override void InitializeGridItem(GridItem gridItem, Point point)
        {
            ((GridItemClickable)gridItem).Initialize(point, this);
        }

        public virtual void OnChildButtonClicked(GridItemClickable gridItem)
        {
            uiLevel.OnButtonGridItemClicked(gridItem);
        }
        
        public void UpdateGridByCheckResultAnswer(PlayerLevel.PlayerLevel playerLevel)
        {
            UpdateGridBy(playerLevel.GetResultDataForUpdateCell);
        }
        
        public void UpdateGridByCorrectSolvedGrid(LevelSolver.LevelSolver levelSolverLevel)
        {
            UpdateGridBy(levelSolverLevel.GetGridItemDataAtPoint);
        }

        public void UpdateGridByExplanationMistakeResultAnswer(GridItem gridItem, LevelSolver.LevelSolver levelSolver)
        {
            UpdateGridBy(levelSolver.GetGridForResultExplanationPanel(gridItem.Point));
        }

        public void UpdateGridByPlayerLevelGrid(PlayerLevel.PlayerLevel playerLevel)
        {
            UpdateGridBy(playerLevel.GetGritItemDataAtPoint);
        }

        public void UpdateGridByPreviousGridValues()
        {
        //    UpdateGridBy(((PlayerLevel1)uiLevel.PlayerLevel).GetPreviousGridItemStatus);
        }
    }
}
