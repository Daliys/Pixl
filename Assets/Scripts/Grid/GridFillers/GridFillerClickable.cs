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
            
        }
        
        
        public void UpdateGridByResultValue()
        {
         //   UpdateGridByResultData(((LevelSolverLevel1)uiLevel.LevelSolver).GetCellStatusAtPoint,((PlayerLevel1)uiLevel.PlayerLevel).GetClickableGridItemResultStatus);
        }

        public void UpdateGridByPlayerLevelGrid()
        {
         //   UpdateGridBy(((PlayerLevel1)uiLevel.PlayerLevel).GetCellStatusAtPoint);
        }

        public void UpdateGridByPreviousGridValues()
        {
        //    UpdateGridBy(((PlayerLevel1)uiLevel.PlayerLevel).GetPreviousGridItemStatus);
        }
    }
}
